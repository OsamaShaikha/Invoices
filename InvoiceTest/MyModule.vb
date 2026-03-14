Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection
Imports System.Threading

Module MyModule

    'Dim connectionString As String = "Server=.\SQLEXPRESS;Database=INVOICE_DB;Trusted_Connection=True;"
    Dim connectionString As String = "Data Source=SrvApp;Initial Catalog=INVOICE_DB;user id=sa;Password=Sys@123;MultipleActiveResultSets=true;Connection Timeout=10;TrustServerCertificate=True;"
    Public con As New SqlClient.SqlConnection(connectionString)

    Public Pu_LongDatePattern As String = "dd/MM/yyyy HH:mm:ss"
    Public Pu_LongTimePattern As String = "HH:mm:ss"
    Public Pu_ShortTimePattern As String = "HH:mm"
    Public Pu_ShortDatePattern As String = "dd/MM/yyyy"
    Public Pu_DateSeparator As String = "/"

    Public Pu_AllDatePattern As String() = {"dd/MM/yyyy", "ddMMyyyy", "dd/MM/yyyy HH:mm:ss", "dd/MM/yyyy HH:mm", "dd/MM/yyyy hh:mm:ss", "ddMMyyyy hh:mm", "ddMMyyyy HH:mm:ss", "ddMMyyyy HH:mm", "ddMMyyyy hh:mm:ss", "ddMMyyyy hh:mm",
        "d/MM/yyyy", "dMMyyyy", "d/MM/yyyy HH:mm:ss", "d/MM/yyyy HH:mm", "d/MM/yyyy hh:mm:ss", "dMMyyyy hh:mm", "dMMyyyy HH:mm:ss", "dMMyyyy HH:mm", "dMMyyyy hh:mm:ss", "dMMyyyy hh:mm",
        "dd/M/yyyy", "ddMyyyy", "dd/M/yyyy HH:mm:ss", "dd/M/yyyy HH:mm", "dd/M/yyyy hh:mm:ss", "ddMyyyy hh:mm", "ddMyyyy HH:mm:ss", "ddMyyyy HH:mm", "ddMyyyy hh:mm:ss", "ddMyyyy hh:mm",
        "dd/MM/yy", "ddMMyy", "dd/MM/yy HH:mm:ss", "dd/MM/yy HH:mm", "dd/MM/yy hh:mm:ss", "ddMMyy hh:mm", "ddMMyy HH:mm:ss", "ddMMyy HH:mm", "ddMMyy hh:mm:ss", "ddMMyy hh:mm",
        "d/M/yyyy", "dMyyyy", "d/M/yyyy HH:mm:ss", "d/M/yyyy HH:mm", "d/M/yyyy hh:mm:ss", "dMyyyy hh:mm", "dMyyyy HH:mm:ss", "dMyyyy HH:mm", "dMyyyy hh:mm:ss", "dMyyyy hh:mm",
        "dd/MM/yy", "ddMMyy", "dd/MM/yy HH:mm:ss", "dd/MM/yy HH:mm", "dd/MM/yy hh:mm:ss", "ddMMyy hh:mm", "ddMMyy HH:mm:ss", "ddMMyy HH:mm", "ddMMyy hh:mm:ss", "ddMMyy hh:mm",
        "d/MM/yy", "dMMyy", "d/MM/yy HH:mm:ss", "d/MM/yy HH:mm", "d/MM/yy hh:mm:ss", "dMMyy hh:mm", "dMMyy HH:mm:ss", "dMMyy HH:mm", "dMMyy hh:mm:ss", "dMMyy hh:mm",
        "dd/M/yy", "ddMyy", "dd/M/yy HH:mm:ss", "dd/M/yy HH:mm", "dd/M/yy hh:mm:ss", "ddMyy hh:mm", "ddMyy HH:mm:ss", "ddMyy HH:mm", "ddMyy hh:mm:ss", "ddMyy hh:mm",
        "dd/MM/yy", "ddMMyy", "dd/MM/yy HH:mm:ss", "dd/MM/yy HH:mm", "dd/MM/yy hh:mm:ss", "ddMMyy hh:mm", "ddMMyy HH:mm:ss", "ddMMyy HH:mm", "ddMMyy hh:mm:ss", "ddMMyy hh:mm",
         "d/M/yy", "dMyy", "d/M/yy HH:mm:ss", "d/M/yy HH:mm", "d/M/yy hh:mm:ss", "dMyy hh:mm", "dMyy HH:mm:ss", "dMyy HH:mm", "dMyy hh:mm:ss", "dMyy hh:mm",
        "dMyy", "Mdyy", "Mdyyyy", "yyyyddMM", "yyyyMMdd", "ddMMyy", "MMddyy", "Mddyyyy", "dd/MM/yyyy HH:mm", "dd/MM/yyyy hh:mm:ss tt", "dd/MM/yyyy hh:mm tt", "dd/MM/yyyy hh:mm:ss tt",
        "dd/MM/yyyy HH:mm:ss", "dd/MM/yyyy HH:mm", "dd/MM/yyyy hh:mm:ss tt", "dd/MM/yyyy hh:mm tt", "dd/MM/yyyy HH:mm:ss", "dd/MM/yyyy HH:mm:ss tt", "d/M/yyyy", "d/M/yy", "d/M/yyy",
        "d.M.yyyy", "d.M.yy", "d.M.yyy", "d-M-yyyy", "d-M-yy", "d-M-yyy", "dd/M/yyyy", "dd/M/yy", "dd/M/yyy", "dd.M.yyyy", "dd.M.yy", "dd.M.yyy", "dd-M-yyyy", "dd-M-yy", "dd-M-yyy", "dd/MM/yyyy", "d/MM/yy", "d/MM/yyy", "d.MM.yyyy", "d.MM.yy", "d.MM.yyy"
                                             }

    Public _dayFirst As String() = {"dd/MM/yyyy", "dd/MM/yyyy HH:mm:ss", "dd/MM/yyyy hh:mm:ss tt", "dd/MM/yyyy HH:mm", "dd/MM/yyyy HH:mm", "dd/MM/yyyy hh:mm tt", "dd/MM/yyyy h:mm:ss tt",
                                         "ddMMyyyy", "ddMMyyyy HH:mm:ss", "ddMMyyyy hh:mm:ss tt", "ddMMyyyy HH:mm", "ddMMyyyy HH:mm", "ddMMyyyy hh:mm tt",
                                         "dd-MM-yyyy", "dd-MM-yyyy HH:mm:ss", "dd-MM-yyyy hh:mm:ss tt", "dd-MM-yyyy HH:mm", "dd-MM-yyyy HH:mm", "dd-MM-yyyy hh:mm tt",
                                         "dd.MM.yyyy", "dd.MM.yyyy HH:mm:ss", "dd.MM.yyyy hh:mm:ss tt", "dd.MM.yyyy HH:mm", "dd.MM.yyyy HH:mm", "dd.MM.yyyy hh:mm tt",
                                         "d/MM/yyyy", "d/MM/yyyy HH:mm:ss", "d/MM/yyyy hh:mm:ss tt", "d/MM/yyyy HH:mm", "d/MM/yyyy HH:mm", "d/MM/yyyy hh:mm tt",
                                         "ddMMyyyy", "dMMyyyy HH:mm:ss", "dMMyyyy hh:mm:ss tt", "dMMyyyy HH:mm", "dMMyyyy HH:mm", "dMMyyyy hh:mm tt",
                                         "d-MM-yyyy", "d-MM-yyyy HH:mm:ss", "d-MM-yyyy hh:mm:ss tt", "d-MM-yyyy HH:mm", "d-MM-yyyy HH:mm", "d-MM-yyyy hh:mm tt",
                                         "d.MM.yyyy", "d.MM.yyyy HH:mm:ss", "d.MM.yyyy hh:mm:ss tt", "d.MM.yyyy HH:mm", "d.MM.yyyy HH:mm", "d.MM.yyyy hh:mm tt",
                                         "dd/M/yyyy", "dd/MM/yyyy HH:mm:ss", "dd/MM/yyyy hh:mm:ss tt", "dd/MM/yyyy HH:mm", "dd/MM/yyyy HH:mm", "dd/MM/yyyy hh:mm tt",
                                         "ddMyyyy", "ddMyyyy HH:mm:ss", "ddMyyyy hh:mm:ss tt", "ddMyyyy HH:mm", "ddMyyyy HH:mm", "ddMyyyy hh:mm tt",
                                         "dd-M-yyyy", "dd-M-yyyy HH:mm:ss", "dd-M-yyyy hh:mm:ss tt", "dd-M-yyyy HH:mm", "dd-M-yyyy HH:mm", "dd-M-yyyy hh:mm tt",
                                         "dd.M.yyyy", "dd.M.yyyy HH:mm:ss", "dd.M.yyyy hh:mm:ss tt", "dd.M.yyyy HH:mm", "dd.M.yyyy HH:mm", "dd.M.yyyy hh:mm tt",
                                         "d/M/yyyy", "dd/MM/yyyy HH:mm:ss", "d/M/yyyy hh:mm:ss tt", "d/M/yyyy HH:mm", "d/M/yyyy HH:mm", "d/M/yyyy hh:mm tt",
                                         "dMyyyy", "dMyyyy HH:mm:ss", "dMyyyy hh:mm:ss tt", "dMyyyy HH:mm", "dMyyyy HH:mm", "dMyyyy hh:mm tt",
                                         "d-M-yyyy", "d-M-yyyy HH:mm:ss", "d-M-yyyy hh:mm:ss tt", "d-M-yyyy HH:mm", "dd-MM-yyyy HH:mm", "d-M-yyyy hh:mm tt",
                                         "d.M.yyyy", "d.M.yyyy HH:mm:ss", "d.M.yyyy hh:mm:ss tt", "d.M.yyyy HH:mm", "dd.MM.yyyy HH:mm", "d.M.yyyy hh:mm tt",
                                          "dd/MM/yy", "dd/MM/yy HH:mm:ss", "dd/MM/yy hh:mm:ss tt", "dd/MM/yy HH:mm", "dd/MM/yyyy HH:mm", "dd/MM/yy hh:mm tt",
                                         "ddMMyy", "ddMMyy HH:mm:ss", "ddMMyy hh:mm:ss tt", "ddMMyy HH:mm", "ddMMyy HH:mm", "ddMMyy hh:mm tt",
                                         "dd-MM-yy", "dd-MM-yy HH:mm:ss", "dd-MM-yy hh:mm:ss tt", "dd-MM-yy HH:mm", "dd-MM-yy HH:mm", "dd-MM-yy hh:mm tt",
                                         "dd.MM.yy", "dd.MM.yy HH:mm:ss", "dd.MM.yy hh:mm:ss tt", "dd.MM.yy HH:mm", "dd.MM.yy HH:mm", "dd.MM.yy hh:mm tt",
                                         "d/MM/yy", "d/MM/yy HH:mm:ss", "d/MM/yy hh:mm:ss tt", "d/MM/yy HH:mm", "d/MM/yy HH:mm", "d/MM/yy hh:mm tt",
                                         "ddMMyy", "dMMyy HH:mm:ss", "dMMyy hh:mm:ss tt", "dMMyy HH:mm", "dMMyy HH:mm", "dMMyy hh:mm tt",
                                         "d-MM-yy", "d-MM-yy HH:mm:ss", "d-MM-yy hh:mm:ss tt", "d-MM-yy HH:mm", "d-MM-yy HH:mm", "d-MM-yy hh:mm tt",
                                         "d.MM.yy", "d.MM.yy HH:mm:ss", "d.MM.yy hh:mm:ss tt", "d.MM.yy HH:mm", "d.MM.yy HH:mm", "d.MM.yy hh:mm tt",
                                         "dd/M/yy", "dd/MM/yy HH:mm:ss", "dd/MM/yy hh:mm:ss tt", "dd/MM/yy HH:mm", "dd/MM/yy HH:mm", "dd/MM/yy hh:mm tt",
                                         "ddMyy", "ddMyy HH:mm:ss", "ddMyy hh:mm:ss tt", "ddMyy HH:mm", "ddMyy HH:mm", "ddMyy hh:mm tt",
                                         "dd-M-yy", "dd-M-yy HH:mm:ss", "dd-M-yyyy hh:mm:ss tt", "dd-M-yyyy HH:mm", "dd-M-yyyy HH:mm", "dd-M-yy hh:mm tt",
                                         "dd.M.yy", "dd.M.yy HH:mm:ss", "dd.M.yy hh:mm:ss tt", "dd.M.yy HH:mm", "dd.M.yy HH:mm", "dd.M.yy hh:mm tt",
                                         "d/M/yy", "dd/MM/yy HH:mm:ss", "d/M/yy hh:mm:ss tt", "d/M/yy HH:mm", "d/M/yy HH:mm", "d/M/yy hh:mm tt",
                                         "dMyy", "dMyy HH:mm:ss", "dMyy hh:mm:ss tt", "dMyy HH:mm", "dMyyyy HH:mm", "dMyy hh:mm tt",
                                         "d-M-yy", "d-M-yy HH:mm:ss", "d-M-yy hh:mm:ss tt", "d-M-yy HH:mm", "dd-MM-yy HH:mm", "d-M-yy hh:mm tt",
                                         "d.M.yy", "d.M.yy HH:mm:ss", "d.M.yy hh:mm:ss tt", "d.M.yy HH:mm", "dd.MM.yy HH:mm", "d.M.yy hh:mm tt",
                                         "h:mm:ss tt", "hh:mm:ss tt", "H:mm:ss tt", "HH:mm", "HH:mm:ss", "hh:mm:ss", "yyyy/MM/dd", "hh:mm tt", "hh: mm tt"}


    Public Function FormatOnlyDate(a_date As String,
                               Optional a_LongDatePattern As String = Nothing,
                               Optional a_ShortDatePattern As String = Nothing,
                               Optional a_ShortTimePattern As String = Nothing,
                               Optional a_DateSeparator As String = Nothing) As Date

        Dim Pu_formateInfo = New DateTimeFormatInfo() With {.LongDatePattern = Nvl(a_LongDatePattern, Pu_LongDatePattern),
                                                           .ShortDatePattern = Nvl(a_ShortDatePattern, Pu_ShortDatePattern),
                                                           .ShortTimePattern = Nvl(a_ShortTimePattern, Pu_ShortTimePattern),
                                                           .DateSeparator = Nvl(a_DateSeparator, Pu_DateSeparator)}

        Try

            Dim enUS As CultureInfo = New CultureInfo("en-US")
            enUS.DateTimeFormat.ShortDatePattern = Pu_ShortDatePattern
            Thread.CurrentThread.CurrentCulture = enUS

            Dim DateValue As Date

            If DateTime.TryParseExact(a_date, _dayFirst, enUS,
              DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "dd/MM/yyyy hh:mm:ss tt", enUS,
             DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "g", enUS,
                                 DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "g", enUS,
                                 DateTimeStyles.AllowLeadingWhite, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "M/dd/yyyy hh:mm", enUS,
                                 DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "MM/dd/yyyy hh:mm", enUS,
                              DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "MM/dd/yyyy hh:mm:ss tt zzz", enUS,
                              DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "MM/dd/yyyy hh:mm:ss tt zzz", enUS,
                              DateTimeStyles.AdjustToUniversal, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "o", CultureInfo.InvariantCulture,
                                     DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "o", CultureInfo.InvariantCulture,
                                 DateTimeStyles.RoundtripKind, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "dd/MM/yyyy", enUS,
                                 DateTimeStyles.None, DateValue) Then
                Return DateValue
            ElseIf DateTime.TryParseExact(a_date, "dd/MM/yyyy hh:mm:ss tt", enUS,
                 DateTimeStyles.None, DateValue) Then
                Return DateValue
            End If


            Try
                'Dim MyDate As String = a_date
                'Dim MyNew As DateTime
                'MyNew = Convert.ToDateTime(MyDate, Pu_formateInfo)
                Dim MyNew As DateTime = DateTime.ParseExact(a_date, Pu_AllDatePattern, enUS, System.Globalization.DateTimeStyles.None)

                Return MyNew
            Catch ex2 As Exception
                'Dim MyDate As String = a_date.ToString("dd/MM/yyyy HH:mm:ss")
                'Dim MyNew As DateTime = Date.Parse(a_date)
                'MyNew = Convert.ToDateTime(MyNew, Pu_formateInfo)
                Return Nothing
            End Try

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function FormatDate(a_date As String,
                               Optional a_LongDatePattern As String = Nothing,
                               Optional a_ShortDatePattern As String = Nothing,
                               Optional a_ShortTimePattern As String = Nothing,
                               Optional a_DateSeparator As String = Nothing
                               ) As DateTime
        Dim Pu_formateInfo = New DateTimeFormatInfo() With {.LongDatePattern = Nvl(a_LongDatePattern, Pu_LongDatePattern),
                                                           .ShortDatePattern = Nvl(a_ShortDatePattern, Pu_ShortDatePattern),
                                                           .ShortTimePattern = Nvl(a_ShortTimePattern, Pu_ShortTimePattern),
                                                           .DateSeparator = Nvl(a_DateSeparator, Pu_DateSeparator)}
        Try

            Return FormatOnlyDate(a_date, a_LongDatePattern, a_ShortDatePattern, a_ShortTimePattern, a_DateSeparator)

            Dim enUS As CultureInfo = New CultureInfo("en-US")
            Dim myDate As DateTime = DateTime.ParseExact(a_date, Pu_AllDatePattern, enUS, System.Globalization.DateTimeStyles.None)

            Return myDate
        Catch ex As Exception
            Try
                Dim MyDate As String = a_date
                Dim MyNew As DateTime
                MyNew = Convert.ToDateTime(MyDate, Pu_formateInfo)
                Return MyNew
            Catch ex2 As Exception
                'Dim MyDate As String = a_date.ToString("dd/MM/yyyy HH:mm:ss")
                Dim MyNew As DateTime = Date.Parse(a_date)
                MyNew = Convert.ToDateTime(MyNew, Pu_formateInfo)
                Return MyNew
            End Try


        End Try
    End Function
    Public Function Nvl(ByVal str As Object,
                            Optional ByVal ConvertDBNullTO As Object = Nothing,
                            Optional ByVal ForChkFields As Boolean = False,
                            Optional ByVal a_type As Type = Nothing)

        Try

            Dim v_type As Type = GetType(String)

            If a_type IsNot Nothing Then
                v_type = a_type
            End If

            If ForChkFields = True Then
                Try
                    If IsDBNull(str) = False AndAlso TypeOf str Is Date Then
                        If IsNumeric(str) = False Then

                            ' Dim s As String = Format(str, Pu_ShortDatePattern)
                            Return FormatDate(str, Pu_ShortDatePattern)
                        End If
                    End If
                    If IsDBNull(str) = False Then
                        If str = "0" Then
                            Return "0"
                        End If
                    End If

                    If IsDBNull(str) = False AndAlso str <> Nothing Then
                        Return str
                    End If

                    'تبديل قيمة الديبي نل بالقيمة المرسلة 
                    If ConvertDBNullTO <> Nothing Then
                        Return ConvertDBNullTO
                    End If

                    Return Nothing
                Catch ex As Exception
                    Return Nothing
                End Try
            Else
                If IsDBNull(str) = False AndAlso TypeOf str Is Date Then
                    If IsNumeric(str) = False Then
                        ' Dim s As String = Format(str, Pu_ShortDatePattern)
                        Return FormatDate(str, Pu_ShortDatePattern)
                    End If
                End If

                If IsDBNull(str) = False AndAlso IsNumeric(str) Then
                    If v_type = GetType(Integer) Then
                        Return Integer.Parse(str)
                    ElseIf v_type = GetType(Int16) Then
                        Return Convert.ToInt16(str)
                    ElseIf v_type = GetType(Int32) Then
                        Return Convert.ToInt32(str)
                    ElseIf v_type = GetType(Int64) Then
                        Return Convert.ToInt64(str)
                    ElseIf v_type = GetType(Decimal) Then
                        Return Convert.ToDecimal(str)
                    ElseIf v_type = GetType(Double) Then
                        Return Convert.ToDouble(str)
                    ElseIf a_type = GetType(String) Then
                        Return str
                    Else
                        Return Convert.ToDecimal(str)
                    End If

                End If

                If IsDBNull(str) = False Then
                    If str = "0" Then
                        Return 0
                    End If
                End If


                If IsDBNull(str) = False AndAlso str <> Nothing Then
                    If IsDate(str) Then
                        Return FormatDate(str, Pu_ShortDatePattern)
                    End If
                    Return str
                End If



                If IsDBNull(ConvertDBNullTO) = False Then
                    If IsNumeric(ConvertDBNullTO) = False AndAlso IsDate(ConvertDBNullTO) Then
                        Return Date.Parse(FormatDate(ConvertDBNullTO, Pu_ShortDatePattern))
                    End If
                    If IsNumeric(ConvertDBNullTO) Then
                        If v_type = GetType(Integer) Then
                            Return Integer.Parse(ConvertDBNullTO)
                        ElseIf v_type = GetType(Int16) Then
                            Return Convert.ToInt16(ConvertDBNullTO)
                        ElseIf v_type = GetType(Int32) Then
                            Return Convert.ToInt32(ConvertDBNullTO)
                        ElseIf v_type = GetType(Int64) Then
                            Return Convert.ToInt64(ConvertDBNullTO)
                        ElseIf v_type = GetType(Decimal) Then
                            Return Convert.ToDecimal(ConvertDBNullTO)
                        ElseIf v_type = GetType(Double) Then
                            Return Convert.ToDouble(ConvertDBNullTO)
                        ElseIf a_type = GetType(String) Then
                            Return ConvertDBNullTO
                        Else
                            Return Convert.ToDecimal(ConvertDBNullTO)
                        End If
                    End If

                    Return ConvertDBNullTO
                End If

                If IsDBNull(ConvertDBNullTO) Then
                    Return Nothing
                End If

                Return Nothing

            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function IsFeildNull(ByVal ObjValue As Object) As Boolean
        Try

            Try
                If IsDBNull(ObjValue) Then
                    Return True
                End If
            Catch ex As Exception

            End Try

            Try
                If Nvl(ObjValue, Nothing) Is Nothing Then
                    Return True
                End If
            Catch ex As Exception

            End Try

            If String.IsNullOrEmpty(ObjValue) Then
                Return True
            End If

            If String.IsNullOrWhiteSpace(ObjValue) Then
                Return True
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function





    Public Function DataTableToBindingList(Of T As New)(dt As DataTable) As BindingList(Of T)
        Dim list As New BindingList(Of T)()

        For Each row As DataRow In dt.Rows
            Dim obj As New T()

            For Each prop As PropertyInfo In GetType(T).GetProperties()
                If dt.Columns.Contains(prop.Name) AndAlso Not IsDBNull(row(prop.Name)) Then
                    prop.SetValue(obj, row(prop.Name))
                End If
            Next

            list.Add(obj)
        Next

        Return list
    End Function
End Module
