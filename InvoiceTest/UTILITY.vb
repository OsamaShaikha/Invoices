Imports System.Data.SqlClient

Public Class UTILITY
    Public Shared Sub FillSearchLookUpEdit(ByRef srchGrid As DevExpress.XtraEditors.SearchLookUpEdit,
                                                          ByVal SqlQry As String)
        Dim data As New DataTable

        Try

            srchGrid.Properties.DataSource = data

            If String.IsNullOrWhiteSpace(SqlQry) Then
                Return
            End If

            data = FillDataTable(SqlQry)

            srchGrid.Properties.DataSource = data
            srchGrid.Properties.ValueMember = data.Columns(0).ColumnName
            srchGrid.Properties.DisplayMember = data.Columns(1).ColumnName

        Catch ex As Exception

        End Try
    End Sub




    Public Shared Sub FillRepositorySearchLookUpEdit(ByRef srchGrid As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit,
                                                          ByVal SqlQry As String)
        Dim data As New DataTable

        Try

            srchGrid.DataSource = data

            If String.IsNullOrWhiteSpace(SqlQry) Then
                Return
            End If

            data = FillDataTable(SqlQry)

            srchGrid.DataSource = data
            srchGrid.ValueMember = data.Columns(0).ColumnName
            srchGrid.DisplayMember = data.Columns(1).ColumnName

        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function FillDataTable(ByVal SqlQry As String) As DataTable
        Dim dt As New DataTable
        Try

            If String.IsNullOrEmpty(SqlQry) Then
                Return dt
            End If

            Using cmd As New SqlCommand(SqlQry, con)

                Using da As New SqlDataAdapter(cmd)

                    con.Open()
                    da.Fill(dt)
                    con.Close()
                End Using

            End Using

            Return dt
        Catch ex As Exception
            con.Close()
            Return dt
        Finally
            con.Close()
        End Try
    End Function

    Public Shared Sub FillCombobox(ByRef combobox As ComboBox,
                                   ByVal SqlQry As String,
                                   Optional ByVal AddEmptyRow As Boolean = False,
                                   Optional ByVal EmptyRecSer As String = "-1",
                                   Optional ByVal EmptyStr As String = "")
        Try

            Dim dt As New DataTable
            dt = FillDataTable(SqlQry)


            If AddEmptyRow = True Then
                Dim row = dt.NewRow
                row(0) = EmptyRecSer
                row(1) = EmptyStr
                Try
                    row(2) = ""
                Catch ex As Exception

                End Try

                dt.Rows.Add(row)
            End If

            If dt.Rows.Count > 0 Then


                combobox.DataSource = dt
                combobox.ValueMember = dt.Columns(0).ToString()


                combobox.DisplayMember = dt.Columns(1).ToString()



                    If combobox.DropDownStyle = ComboBoxStyle.DropDown Then
                    combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
                    combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
                End If

                combobox.SelectedIndex = -1
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
