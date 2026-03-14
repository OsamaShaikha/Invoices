Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class FRM_INV_TARNSACTIONS
    Private pr_gridview As BindingList(Of INV_TRANSACTIONS_DETAILS) = New BindingList(Of INV_TRANSACTIONS_DETAILS)
    Private Sub INITIALIZE()
        UTILITY.FillCombobox(com_TRANS_TYPE, "SELECT CODE_MNR, CODE_DESC FROM SYS_CODE WHERE CODE_MGR = 1 AND CODE_MNR <> 0 ORDER BY CODE_MNR")
        UTILITY.FillCombobox(com_TRANS_TYPE_CODE, "SELECT CODE_MNR, CODE_DESC FROM SYS_CODE WHERE CODE_MGR = 2 AND CODE_MNR in (101,102) ORDER BY CODE_MNR")
        UTILITY.FillCombobox(com_TAX_TYPE, "SELECT CODE_MNR, CODE_DESC FROM SYS_CODE WHERE CODE_MGR = 3 AND CODE_MNR <> 0 ORDER BY CODE_MNR")
        UTILITY.FillCombobox(com_PAYMENT_METHOD, "SELECT CODE_MNR, CODE_DESC FROM SYS_CODE WHERE CODE_MGR = 4 AND CODE_MNR <> 0 ORDER BY CODE_MNR")

        UTILITY.FillRepositorySearchLookUpEdit(r_INV_ITEM_CARDS, "SELECT ITEM_CARD_CODE, ITEM_CARD_ARABIC_NAME FROM INV_ITEM_CARD")

        UTILITY.FillSearchLookUpEdit(com_REPRESENTATIVE, "SELECT CODE_MNR, CODE_DESC FROM SYS_CODE WHERE CODE_MGR = 5 AND CODE_MNR <> 0 ORDER BY CODE_MNR")
        UTILITY.FillSearchLookUpEdit(com_CUSTOMER, "SELECT CODE_MNR, CODE_DESC FROM SYS_CODE WHERE CODE_MGR = 6 AND CODE_MNR <> 0 ORDER BY CODE_MNR")

        com_TRANS_TYPE.SelectedValue = 1
        com_TRANS_TYPE_CODE.SelectedValue = 101
        com_TAX_TYPE.SelectedValue = 1
        com_PAYMENT_METHOD.SelectedValue = 1

        txt_TRANS_DATE.EditValue = Now
        txt_TRANS_YEAR.Text = Now.Year

        com_REPRESENTATIVE.EditValue = 0
        com_CUSTOMER.EditValue = 0
        txt_TRANS_NO.Text = Nothing
        txt_NOTE.Text = Nothing

        txt_TRANS_DATE.Focus()
    End Sub
    Private Sub FRM_INV_TARNSACTIONS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INITIALIZE()

        GridControl_INV_TARNSACTIONS_DETAILS.DataSource = pr_gridview
    End Sub

    Private Sub com_TRANS_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_TRANS_TYPE.SelectedIndexChanged
        If Nvl(com_TRANS_TYPE.SelectedValue, 0) < 0 Then
            Return
        End If

        If Nvl(com_TRANS_TYPE.SelectedValue) = 1 Then
            colQTY_OUT.Visible = True
            colQTY_IN.Visible = False
        ElseIf Nvl(com_TRANS_TYPE.SelectedValue) = 2 Then
            colQTY_OUT.Visible = False
            colQTY_IN.Visible = True
        End If
    End Sub

    Private Sub com_TRANS_TYPE_CODE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_TRANS_TYPE_CODE.SelectedIndexChanged
        If Nvl(com_TRANS_TYPE_CODE.SelectedValue, 0) < 0 Then
            Return
        End If
        If Nvl(com_TRANS_TYPE_CODE.SelectedValue) = 102 Then
            com_PAYMENT_METHOD.SelectedValue = 0
            com_PAYMENT_METHOD.Enabled = False
        Else
            com_PAYMENT_METHOD.Enabled = True
            com_PAYMENT_METHOD.SelectedValue = 1
        End If


    End Sub

    Private Sub txt_TRANS_DATE_EditValueChanged(sender As Object, e As EventArgs) Handles txt_TRANS_DATE.EditValueChanged
        txt_TRANS_YEAR.Text = FormatDate(txt_TRANS_DATE.Text).Year
    End Sub

    Private Sub GridView_INV_TARNSACTIONS_DETAILS_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView_INV_TARNSACTIONS_DETAILS.ValidateRow
        Dim V_NVOICE_CALC As INVOICE_CALC = New INVOICE_CALC


        V_NVOICE_CALC = fiscal.Get_invoice_calc(com_TAX_TYPE.SelectedValue,
                                Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colQTY_IN), 0) + Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colQTY_OUT), 0),
                                Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colDISCOUNT_PCNT), 0),
                                  Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colINDIVIDUAL_PRICE), 0),
                               Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colTAX_PCNT), 16),
                                0)

        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colTAX_AMT, V_NVOICE_CALC.TAX_AMOUNT)
        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colTOTAL_AMT, V_NVOICE_CALC.TOTAL_AMOUNT)
        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colNET_AMT, V_NVOICE_CALC.NET_AMOUNT)
        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colDISCOUNT_AMT, V_NVOICE_CALC.DISCOUNT_AMOUNT)



    End Sub

    Function getItemTaxPcnt(item_code As String) As Decimal
        Try
            If item_code Is Nothing Then
                Return 0
            End If
            Dim tax_pcnt As Decimal = UTILITY.FillDataTable($"select ISNULL(ITEM_CARD_TAX_PCNT, 0) from INV_ITEM_CARD where ITEM_CARD_CODE = '{item_code}'")(0)(0)
            Return tax_pcnt
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub GridView_INV_TARNSACTIONS_DETAILS_ValidatingEditor(sender As Object, e As Controls.BaseContainerValidateEditorEventArgs) Handles GridView_INV_TARNSACTIONS_DETAILS.ValidatingEditor

        Dim view = TryCast(sender, GridView)

        Dim column As GridColumn = If(TryCast(e, EditFormValidateEditorEventArgs)?.Column, view.FocusedColumn)

        If column.Name = colITEM_CARD_CODE.Name Then
            GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colTAX_PCNT, getItemTaxPcnt(e.Value))
            GridView_INV_TARNSACTIONS_DETAILS.CloseEditor()
        End If

        Dim V_NVOICE_CALC As INVOICE_CALC = New INVOICE_CALC


        V_NVOICE_CALC = fiscal.Get_invoice_calc(com_TAX_TYPE.SelectedValue,
                                Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colQTY_IN), 0) + Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colQTY_OUT), 0),
                                Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colDISCOUNT_PCNT), 0),
                                  Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colINDIVIDUAL_PRICE), 0),
                               Nvl(GridView_INV_TARNSACTIONS_DETAILS.GetFocusedRowCellValue(colTAX_PCNT), 16),
                                0
                                )

        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colTAX_AMT, V_NVOICE_CALC.TAX_AMOUNT)
        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colTOTAL_AMT, V_NVOICE_CALC.TOTAL_AMOUNT)
        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colNET_AMT, V_NVOICE_CALC.NET_AMOUNT)
        GridView_INV_TARNSACTIONS_DETAILS.SetFocusedRowCellValue(colDISCOUNT_AMT, V_NVOICE_CALC.DISCOUNT_AMOUNT)

    End Sub

    Private Sub btn_SAVE_Click(sender As Object, e As EventArgs) Handles btn_SAVE.Click
        Try
            Dim master As New INV_TARNSACTIONS_MASTER()

            master.TRANS_NO = Nvl(txt_TRANS_NO.Text)
            master.TRANS_YEAR = Nvl(txt_TRANS_YEAR.Text)
            master.TRANS_TYPE_CODE = com_TRANS_TYPE_CODE.SelectedValue
            master.TRANS_TYPE = com_TRANS_TYPE.SelectedValue
            master.PAYMENT_METHOD = com_PAYMENT_METHOD.SelectedValue
            master.TRANS_DATE = FormatDate(txt_TRANS_DATE.Text)
            master.TAX_TYPE = com_TAX_TYPE.SelectedValue
            master.CUSTOMER_CODE = com_CUSTOMER.EditValue
            master.REPRESENTATIVE_CODE = com_REPRESENTATIVE.EditValue
            master.NOTE = txt_NOTE.Text
            master.ENTRY_USER = "admin"
            master.ENTRY_DATE = DateTime.Now



            Dim details As New List(Of INV_TRANSACTIONS_DETAILS)
            details = pr_gridview.ToList


            Dim repo As New TransactionRepository()
            repo.SaveTransaction(master, details)
            txt_TRANS_NO.Text = master.TRANS_NO

            txt_ENTRY_DATE.Text = master.ENTRY_DATE
            txt_ENTRY_USER.Text = master.ENTRY_USER
            txt_UPDATE_USER.Text = master.UPDATE_USER
            txt_UPDATE_DATE.Text = master.UPDATE_DATE

            MessageBox.Show("TRANSACTION SUCCESSFULLY")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub
    Private Sub btn_DELETE_Click(sender As Object, e As EventArgs) Handles btn_DELETE.Click
        Try
            Dim repo As New TransactionRepository()
            Dim master As New INV_TARNSACTIONS_MASTER()

            master.TRANS_NO = Nvl(txt_TRANS_NO.Text)
            master.TRANS_YEAR = Nvl(txt_TRANS_YEAR.Text)
            master.TRANS_TYPE_CODE = com_TRANS_TYPE_CODE.SelectedValue
            repo.DeleteTransaction(master)

            MessageBox.Show("DELETED SUCCESSFULLY")

            btn_NEW.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private dt_mas As DataTable = New DataTable
    Private dt_det As DataTable = New DataTable
    Private record_count As Integer = 0
    Private record_index As Integer = 0


    Sub getRecords()
        Try
            txt_TRANS_NO.Text = Convert.ToInt32(dt_mas(record_index)("TRANS_NO"))
            txt_TRANS_YEAR.Text = Convert.ToInt32(dt_mas(record_index)("TRANS_YEAR"))
            com_TRANS_TYPE_CODE.SelectedValue = Convert.ToInt32(dt_mas(record_index)("TRANS_TYPE_CODE"))
            com_TRANS_TYPE.SelectedValue = If(IsDBNull(dt_mas(record_index)("TRANS_TYPE")), Nothing, Convert.ToInt32(dt_mas(record_index)("TRANS_TYPE")))
            txt_TRANS_DATE.EditValue = If(IsDBNull(dt_mas(record_index)("TRANS_DATE")), Nothing, Convert.ToDateTime(dt_mas(record_index)("TRANS_DATE")))
            com_CUSTOMER.EditValue = If(IsDBNull(dt_mas(record_index)("CUSTOMER_CODE")), Nothing, Convert.ToInt32(dt_mas(record_index)("CUSTOMER_CODE")))
            com_REPRESENTATIVE.EditValue = If(IsDBNull(dt_mas(record_index)("REPRESENTATIVE_CODE")), Nothing, Convert.ToInt32(dt_mas(record_index)("REPRESENTATIVE_CODE")))
            txt_NOTE.Text = If(IsDBNull(dt_mas(record_index)("NOTE")), "", dt_mas(record_index)("NOTE").ToString())
            com_PAYMENT_METHOD.SelectedValue = If(IsDBNull(dt_mas(record_index)("PAYMENT_METHOD")), Nothing, Convert.ToInt32(dt_mas(record_index)("PAYMENT_METHOD")))
            com_TAX_TYPE.SelectedValue = If(IsDBNull(dt_mas(record_index)("TAX_TYPE")), Nothing, Convert.ToInt32(dt_mas(record_index)("TAX_TYPE")))
            txt_ENTRY_DATE.EditValue = If(IsDBNull(dt_mas(record_index)("ENTRY_DATE")), Nothing, Convert.ToDateTime(dt_mas(record_index)("ENTRY_DATE")))
            txt_UPDATE_DATE.EditValue = If(IsDBNull(dt_mas(record_index)("UPDATE_DATE")), Nothing, Convert.ToDateTime(dt_mas(record_index)("UPDATE_DATE")))
            txt_ENTRY_USER.Text = If(IsDBNull(dt_mas(record_index)("ENTRY_USER")), "", dt_mas(record_index)("ENTRY_USER").ToString())
            txt_UPDATE_USER.Text = If(IsDBNull(dt_mas(record_index)("UPDATE_USER")), "", dt_mas(record_index)("UPDATE_USER").ToString())

            Dim repo As New TransactionRepository()
            dt_det = repo.LoadTransactionDetails(Convert.ToInt32(dt_mas(record_index)("TRANS_NO")),
                                                 Convert.ToInt32(dt_mas(record_index)("TRANS_YEAR")),
                                                 Convert.ToInt32(dt_mas(record_index)("TRANS_TYPE_CODE")))

            pr_gridview = DataTableToBindingList(Of INV_TRANSACTIONS_DETAILS)(dt_det)
            GridControl_INV_TARNSACTIONS_DETAILS.DataSource = pr_gridview
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_QUERY_Click(sender As Object, e As EventArgs) Handles btn_QUERY.Click
        Try
            dt_mas = New DataTable
            record_count = 0
            record_index = 0
            Dim repo As New TransactionRepository()
            dt_mas = repo.LoadTransactionMaster()


            If dt_mas.Rows.Count <= 0 Then
                Return
            End If
            record_count = dt_mas.Rows.Count
            getRecords()

        Catch ex As Exception
            record_count = 0
            dt_mas = New DataTable
        End Try
    End Sub

    Private Sub btn_NEXT_Click(sender As Object, e As EventArgs) Handles btn_NEXT.Click
        If dt_mas.Rows.Count <= 0 Then
            Return
        End If
        If record_index = record_count - 1 Then
            Return
        End If
        record_index += 1
        getRecords()
    End Sub

    Private Sub btn_PREV_Click(sender As Object, e As EventArgs) Handles btn_PREV.Click
        If dt_mas.Rows.Count <= 0 Then
            Return
        End If
        If record_index = 0 Then
            Return
        End If
        record_index -= 1
        getRecords()
    End Sub

    Private Sub r_RMEOVE_RECORD_DoubleClick(sender As Object, e As EventArgs) Handles r_RMEOVE_RECORD.DoubleClick
        GridView_INV_TARNSACTIONS_DETAILS.DeleteSelectedRows()
    End Sub

    Private Sub btn_NEW_Click(sender As Object, e As EventArgs) Handles btn_NEW.Click
        INITIALIZE()

        pr_gridview = New BindingList(Of INV_TRANSACTIONS_DETAILS)
        GridControl_INV_TARNSACTIONS_DETAILS.DataSource = pr_gridview
    End Sub

    Protected Overrides Function processcmdKey(ByRef msg As Message, ByVal keydata As Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{tab}")

            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keydata)
    End Function

    Private Sub btn_CLOSE_Click(sender As Object, e As EventArgs) Handles btn_CLOSE.Click
        Me.Dispose()
    End Sub

End Class
