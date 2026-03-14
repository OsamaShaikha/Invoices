Imports System.Data.SqlClient

Public Class TransactionRepository




    '==============================
    ' MAIN SAVE FUNCTION
    '==============================
    Public Sub SaveTransaction(ByRef master As INV_TARNSACTIONS_MASTER,
                               ByRef details As List(Of INV_TRANSACTIONS_DETAILS))


        con.Close()
        con.Open()

        Dim tr = con.BeginTransaction()

        Try

            '-------------------------
            'AUTO GENERATE TRANS_NO
            '-------------------------
            If master.TRANS_NO = 0 Then

                master.TRANS_NO = GetNextTransactionNo(
                        con,
                        tr,
                        master.TRANS_YEAR,
                        master.TRANS_TYPE_CODE
                    )

            End If


            '-------------------------
            'CHECK MASTER EXISTS
            '-------------------------
            Dim checkCmd As New SqlCommand("
                SELECT COUNT(*) FROM INV_TRANSACTIONS_MASTER
                WHERE TRANS_NO=@TRANS_NO
                AND TRANS_YEAR=@TRANS_YEAR
                AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE", con, tr)

            checkCmd.Parameters.AddWithValue("@TRANS_NO", master.TRANS_NO)
            checkCmd.Parameters.AddWithValue("@TRANS_YEAR", master.TRANS_YEAR)
            checkCmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", master.TRANS_TYPE_CODE)

            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())


            '-------------------------
            'INSERT OR UPDATE MASTER
            '-------------------------
            If exists = 0 Then

                Dim insertMaster As New SqlCommand("
                    INSERT INTO INV_TRANSACTIONS_MASTER
                    (TRANS_NO,TRANS_YEAR,TRANS_TYPE_CODE,TRANS_TYPE,TRANS_DATE,
                     REPRESENTATIVE_CODE,CUSTOMER_CODE,NOTE,PAYMENT_METHOD,TAX_TYPE,
                     ENTRY_USER,ENTRY_DATE,UPDATE_USER,UPDATE_DATE)

                    VALUES
                    (@TRANS_NO,@TRANS_YEAR,@TRANS_TYPE_CODE,@TRANS_TYPE,@TRANS_DATE,
                     @REPRESENTATIVE_CODE,@CUSTOMER_CODE,@NOTE,@PAYMENT_METHOD,@TAX_TYPE,
                     @ENTRY_USER,@ENTRY_DATE,@UPDATE_USER,@UPDATE_DATE)", con, tr)

                AddMasterParameters(insertMaster, master, 1)

                insertMaster.ExecuteNonQuery()

            Else

                Dim updateMaster As New SqlCommand("
                    UPDATE INV_TRANSACTIONS_MASTER
                    SET
                    TRANS_TYPE=@TRANS_TYPE,
                    TRANS_DATE=@TRANS_DATE,
                    REPRESENTATIVE_CODE=@REPRESENTATIVE_CODE,
                    CUSTOMER_CODE=@CUSTOMER_CODE,
                    NOTE=@NOTE,
                    PAYMENT_METHOD=@PAYMENT_METHOD,
                    TAX_TYPE=@TAX_TYPE,
                    UPDATE_USER=@UPDATE_USER,
                    UPDATE_DATE=@UPDATE_DATE

                    WHERE
                    TRANS_NO=@TRANS_NO
                    AND TRANS_YEAR=@TRANS_YEAR
                    AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE", con, tr)

                AddMasterParameters(updateMaster, master, 2)

                updateMaster.ExecuteNonQuery()

                master.UPDATE_USER = master.ENTRY_USER
                master.UPDATE_DATE = master.ENTRY_DATE

            End If


            '-------------------------
            'LOAD EXISTING DETAILS
            '-------------------------
            Dim existing As New List(Of Integer)

            Dim loadCmd As New SqlCommand("
                SELECT TRANS_NO_DETAILS
                FROM INV_TRANSACTIONS_DETAILS
                WHERE TRANS_NO=@TRANS_NO
                AND TRANS_YEAR=@TRANS_YEAR
                AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE", con, tr)

            loadCmd.Parameters.AddWithValue("@TRANS_NO", master.TRANS_NO)
            loadCmd.Parameters.AddWithValue("@TRANS_YEAR", master.TRANS_YEAR)
            loadCmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", master.TRANS_TYPE_CODE)

            Dim reader = loadCmd.ExecuteReader()

            While reader.Read()

                existing.Add(Convert.ToInt32(reader("TRANS_NO_DETAILS")))

            End While

            reader.Close()


            '-------------------------
            'PROCESS DETAILS
            '-------------------------
            For Each d In details

                d.TRANS_NO = master.TRANS_NO
                d.TRANS_YEAR = master.TRANS_YEAR
                d.TRANS_TYPE_CODE = master.TRANS_TYPE_CODE

                If d.TRANS_NO_DETAILS = 0 Then

                    d.TRANS_NO_DETAILS = GetNextDetailNo(
                        con,
                        tr,
                        master.TRANS_NO,
                        master.TRANS_YEAR,
                        master.TRANS_TYPE_CODE)



                End If

                If existing.Contains(d.TRANS_NO_DETAILS) Then

                    UpdateDetail(con, tr, d)

                    existing.Remove(d.TRANS_NO_DETAILS)

                Else

                    InsertDetail(con, tr, d)

                End If

            Next


            '-------------------------
            'DELETE REMOVED ROWS
            '-------------------------
            For Each id In existing

                Dim delCmd As New SqlCommand("
                    DELETE FROM INV_TRANSACTIONS_DETAILS
                    WHERE TRANS_NO=@TRANS_NO
                    AND TRANS_YEAR=@TRANS_YEAR
                    AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE
                    AND TRANS_NO_DETAILS=@TRANS_NO_DETAILS", con, tr)

                delCmd.Parameters.AddWithValue("@TRANS_NO", master.TRANS_NO)
                delCmd.Parameters.AddWithValue("@TRANS_YEAR", master.TRANS_YEAR)
                delCmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", master.TRANS_TYPE_CODE)
                delCmd.Parameters.AddWithValue("@TRANS_NO_DETAILS", id)

                delCmd.ExecuteNonQuery()

            Next


            tr.Commit()

        Catch

            tr.Rollback()
            Throw

        End Try



    End Sub


    '==============================
    'GET NEXT TRANS_NO
    '==============================
    Private Function GetNextTransactionNo(con As SqlConnection,
                                          tr As SqlTransaction,
                                          year As Integer,
                                          typeCode As Integer) As Integer

        Dim cmd As New SqlCommand("
        SELECT ISNULL(MAX(TRANS_NO),0)+1
        FROM INV_TRANSACTIONS_MASTER
        WHERE TRANS_YEAR=@TRANS_YEAR
        AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE", con, tr)

        cmd.Parameters.AddWithValue("@TRANS_YEAR", year)
        cmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", typeCode)

        Return Convert.ToInt32(cmd.ExecuteScalar())

    End Function


    '==============================
    'GET NEXT DETAIL NO
    '==============================
    Private Function GetNextDetailNo(con As SqlConnection,
                                     tr As SqlTransaction,
                                     transNo As Integer,
                                     year As Integer,
                                     typeCode As Integer) As Integer

        Dim cmd As New SqlCommand("
        SELECT ISNULL(MAX(TRANS_NO_DETAILS),0)+1
        FROM INV_TRANSACTIONS_DETAILS
        WHERE TRANS_NO=@TRANS_NO
        AND TRANS_YEAR=@TRANS_YEAR
        AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE", con, tr)

        cmd.Parameters.AddWithValue("@TRANS_NO", transNo)
        cmd.Parameters.AddWithValue("@TRANS_YEAR", year)
        cmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", typeCode)

        Return Convert.ToInt32(cmd.ExecuteScalar())

    End Function


    '==============================
    'INSERT DETAIL
    '==============================
    Private Sub InsertDetail(con As SqlConnection,
                             tr As SqlTransaction,
                             d As INV_TRANSACTIONS_DETAILS)

        Dim cmd As New SqlCommand("
        INSERT INTO INV_TRANSACTIONS_DETAILS
        (TRANS_NO,TRANS_YEAR,TRANS_TYPE_CODE,TRANS_NO_DETAILS,
         ITEM_CARD_CODE,QTY_IN,QTY_OUT,INDIVIDUAL_PRICE,
         DISCOUNT_PCNT,DISCOUNT_AMT,TAX_PCNT,TAX_AMT,
         TOTAL_AMT,NET_AMT)

        VALUES
        (@TRANS_NO,@TRANS_YEAR,@TRANS_TYPE_CODE,@TRANS_NO_DETAILS,
         @ITEM_CARD_CODE,@QTY_IN,@QTY_OUT,@INDIVIDUAL_PRICE,
         @DISCOUNT_PCNT,@DISCOUNT_AMT,@TAX_PCNT,@TAX_AMT,
         @TOTAL_AMT,@NET_AMT)", con, tr)

        AddDetailParameters(cmd, d)

        cmd.ExecuteNonQuery()

    End Sub


    '==============================
    'UPDATE DETAIL
    '==============================
    Private Sub UpdateDetail(con As SqlConnection,
                             tr As SqlTransaction,
                             d As INV_TRANSACTIONS_DETAILS)

        Dim cmd As New SqlCommand("
        UPDATE INV_TRANSACTIONS_DETAILS
        SET
        ITEM_CARD_CODE=@ITEM_CARD_CODE,
        QTY_IN=@QTY_IN,
        QTY_OUT=@QTY_OUT,
        INDIVIDUAL_PRICE=@INDIVIDUAL_PRICE,
        DISCOUNT_PCNT=@DISCOUNT_PCNT,
        DISCOUNT_AMT=@DISCOUNT_AMT,
        TAX_PCNT=@TAX_PCNT,
        TAX_AMT=@TAX_AMT,
        TOTAL_AMT=@TOTAL_AMT,
        NET_AMT=@NET_AMT

        WHERE
        TRANS_NO=@TRANS_NO
        AND TRANS_YEAR=@TRANS_YEAR
        AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE
        AND TRANS_NO_DETAILS=@TRANS_NO_DETAILS", con, tr)

        AddDetailParameters(cmd, d)

        cmd.ExecuteNonQuery()

    End Sub


    '==============================
    'PARAMETER HELPERS
    '==============================
    Private Sub AddMasterParameters(cmd As SqlCommand, m As INV_TARNSACTIONS_MASTER, TRX_TYPE As Integer)

        cmd.Parameters.AddWithValue("@TRANS_NO", m.TRANS_NO)
        cmd.Parameters.AddWithValue("@TRANS_YEAR", m.TRANS_YEAR)
        cmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", m.TRANS_TYPE_CODE)
        cmd.Parameters.AddWithValue("@TRANS_TYPE", m.TRANS_TYPE)
        cmd.Parameters.AddWithValue("@TRANS_DATE", m.TRANS_DATE)
        cmd.Parameters.AddWithValue("@REPRESENTATIVE_CODE", m.REPRESENTATIVE_CODE)
        cmd.Parameters.AddWithValue("@CUSTOMER_CODE", m.CUSTOMER_CODE)
        cmd.Parameters.AddWithValue("@NOTE", m.NOTE)
        cmd.Parameters.AddWithValue("@PAYMENT_METHOD", m.PAYMENT_METHOD)
        cmd.Parameters.AddWithValue("@TAX_TYPE", m.TAX_TYPE)
        cmd.Parameters.AddWithValue("@ENTRY_USER", m.ENTRY_USER)
        cmd.Parameters.AddWithValue("@ENTRY_DATE", m.ENTRY_DATE)

        If TRX_TYPE = 1 Then
            cmd.Parameters.AddWithValue("@UPDATE_USER", DBNull.Value)
            cmd.Parameters.AddWithValue("@UPDATE_DATE", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@UPDATE_USER", m.ENTRY_USER)
            cmd.Parameters.AddWithValue("@UPDATE_DATE", m.ENTRY_DATE)
        End If


    End Sub


    Private Sub AddDetailParameters(cmd As SqlCommand, d As INV_TRANSACTIONS_DETAILS)

        cmd.Parameters.AddWithValue("@TRANS_NO", d.TRANS_NO)
        cmd.Parameters.AddWithValue("@TRANS_YEAR", d.TRANS_YEAR)
        cmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", d.TRANS_TYPE_CODE)
        cmd.Parameters.AddWithValue("@TRANS_NO_DETAILS", d.TRANS_NO_DETAILS)
        cmd.Parameters.AddWithValue("@ITEM_CARD_CODE", d.ITEM_CARD_CODE)
        cmd.Parameters.AddWithValue("@QTY_IN", If(d.QTY_IN, DBNull.Value))
        cmd.Parameters.AddWithValue("@QTY_OUT", If(d.QTY_OUT, DBNull.Value))
        cmd.Parameters.AddWithValue("@INDIVIDUAL_PRICE", d.INDIVIDUAL_PRICE)
        cmd.Parameters.AddWithValue("@DISCOUNT_PCNT", d.DISCOUNT_PCNT)
        cmd.Parameters.AddWithValue("@DISCOUNT_AMT", d.DISCOUNT_AMT)
        cmd.Parameters.AddWithValue("@TAX_PCNT", d.TAX_PCNT)
        cmd.Parameters.AddWithValue("@TAX_AMT", d.TAX_AMT)
        cmd.Parameters.AddWithValue("@TOTAL_AMT", d.TOTAL_AMT)
        cmd.Parameters.AddWithValue("@NET_AMT", d.NET_AMT)

    End Sub



    '""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""

    Public Sub DeleteTransaction(master As INV_TARNSACTIONS_MASTER)


        con.Close()
        con.Open()

        Dim tr = con.BeginTransaction()

        Try


            Dim delCmdDet As New SqlCommand("
                    DELETE FROM INV_TRANSACTIONS_DETAILS
                    WHERE TRANS_NO=@TRANS_NO
                    AND TRANS_YEAR=@TRANS_YEAR
                    AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE ", con, tr)

            delCmdDet.Parameters.AddWithValue("@TRANS_NO", master.TRANS_NO)
            delCmdDet.Parameters.AddWithValue("@TRANS_YEAR", master.TRANS_YEAR)
            delCmdDet.Parameters.AddWithValue("@TRANS_TYPE_CODE", master.TRANS_TYPE_CODE)

            delCmdDet.ExecuteNonQuery()

            Dim delCmdMas As New SqlCommand("
                    DELETE FROM INV_TRANSACTIONS_MASTER
                    WHERE TRANS_NO=@TRANS_NO
                    AND TRANS_YEAR=@TRANS_YEAR
                    AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE", con, tr)

            delCmdMas.Parameters.AddWithValue("@TRANS_NO", master.TRANS_NO)
            delCmdMas.Parameters.AddWithValue("@TRANS_YEAR", master.TRANS_YEAR)
            delCmdMas.Parameters.AddWithValue("@TRANS_TYPE_CODE", master.TRANS_TYPE_CODE)


            delCmdMas.ExecuteNonQuery()


            tr.Commit()

        Catch

            tr.Rollback()
            Throw

        End Try



    End Sub


    Public Function LoadTransactionMaster() As DataTable
        Dim DT_MAS As DataTable = New DataTable
        Try
            con.Close()
            con.Open()

            Dim masterCmd As New SqlCommand("
                        SELECT *
                        FROM INV_TRANSACTIONS_MASTER  order by TRANS_TYPE_CODE, TRANS_YEAR, TRANS_NO", con)

            Dim adapter_MAS As New SqlDataAdapter(masterCmd)
            adapter_MAS.Fill(DT_MAS)
            con.Close()
            Return DT_MAS
        Catch ex As Exception
            Return DT_MAS
        End Try
    End Function

    Public Function LoadTransactionDetails(transNo As Integer,
                           transYear As Integer,
                           transTypeCode As Integer) As DataTable
        Dim DT_DET As DataTable = New DataTable
        Try
            con.Close()
            con.Open()

            Dim detailCmd As New SqlCommand("
                        SELECT *
                        FROM INV_TRANSACTIONS_DETAILS
                        WHERE TRANS_NO=@TRANS_NO
                        AND TRANS_YEAR=@TRANS_YEAR
                        AND TRANS_TYPE_CODE=@TRANS_TYPE_CODE", con)

            detailCmd.Parameters.AddWithValue("@TRANS_NO", transNo)
            detailCmd.Parameters.AddWithValue("@TRANS_YEAR", transYear)
            detailCmd.Parameters.AddWithValue("@TRANS_TYPE_CODE", transTypeCode)


            Dim adapter_DET As New SqlDataAdapter(detailCmd)
            adapter_DET.Fill(DT_DET)
            con.Close()
            Return DT_DET
        Catch ex As Exception
            Return DT_DET
        End Try
    End Function


End Class
