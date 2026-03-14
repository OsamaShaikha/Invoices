Imports System.Security

Public Class INVOICE_CALC
    Public Property QUENTITY As Decimal?
    Public Property DISCOUNT_PERCENTAGE As Decimal?
    Public Property DISCOUNT As Decimal?
    Public Property QTY As Decimal?
    Public Property ACTUAL_AMT_PRICE As Decimal?
    Public Property TOTAL_AMOUNT As Decimal?
    Public Property DISCOUNT_AMOUNT As Decimal?
    Public Property INDIVIDUAL_PRICE As Decimal?
    Public Property TAX_AMOUNT As Decimal?
    Public Property NET_AMOUNT As Decimal?
    Public Property ITEM_CARD_TAX_PRICE As Decimal?
    Public Property TAX_PERCENTAGE As Decimal?

End Class
Public Class fiscal

    Public Shared Function ROUND_VOHAMT(ByVal XX As Decimal, Optional ByVal decimal_digit As Decimal = 3)
        Try
            Dim YY As Decimal
            Dim RR As Decimal
            Dim CC As Decimal

            YY = XX - Math.Floor(XX)
            RR = ((YY * 100) - Math.Floor(YY * 100)) / 100
            If RR = 0.000 Or RR = 0.005 Then
                CC = XX
            ElseIf RR = 0.001 Then
                CC = XX - 0.001
            ElseIf RR = 0.002 Then
                CC = XX - 0.002
            ElseIf RR = 0.003 Then
                CC = XX + 0.002
            ElseIf RR = 0.004 Then
                CC = XX + 0.001
            ElseIf RR = 0.006 Then
                CC = XX - 0.001
            ElseIf RR = 0.007 Then
                CC = XX - 0.002
            ElseIf RR = 0.008 Then
                CC = XX + 0.002
            ElseIf RR = 0.009 Then
                CC = XX + 0.001
            Else
                CC = XX
            End If


            Return CC
        Catch ex As Exception
            Return XX
        End Try
    End Function


    Public Shared Function Get_invoice_calc(ByVal a_PAYMENT_METHOD As Int64,
                                            ByVal a_QUENTITY As Decimal?,
                                            ByVal a_DISCOUNT_PERCENTAGE As Decimal?,
                                            ByVal a_INDIVIDUAL_PRICE As Decimal?,
                                            ByVal a_TAX_PERCENTAGE As Decimal?,
                                            ByVal a_ITEM_CARD_TAX_PRICE As Decimal?,
                                            Optional ByVal a_calc_disc_amt As Boolean = True
                                            ) As INVOICE_CALC
        Try

            Dim v_QTY As Decimal = 0
            Dim v_DISCOUNT As Decimal = 0
            Dim v_special_tax_tot_price As Decimal = 0
            Dim v_PAYMENT_METHOD As Decimal = a_PAYMENT_METHOD
            Dim v_DISCOUNT_AMOUNT As Decimal = 0
            Dim v_ACTUAL_AMT_PRICE As Decimal = 0
            Dim v_TOTAL_AMOUNT As Decimal = 0
            Dim v_TAX_AMOUNT As Decimal = 0
            Dim v_NET_AMOUNT As Decimal = 0
            '----------------------

            '----------------------
            ' --------------PRICE WITHOUT TAX  
            If Nvl(v_PAYMENT_METHOD, 1) = 2 Then

                '---------------
                v_QTY = Nvl(a_QUENTITY, 0)
                v_DISCOUNT = Nvl(a_DISCOUNT_PERCENTAGE, 0) / 100
                '---------------------



                '---------------------
                If a_calc_disc_amt Then
                    v_DISCOUNT_AMOUNT = ROUND_VOHAMT(v_DISCOUNT * v_QTY * a_INDIVIDUAL_PRICE)
                End If
                '---------------------

                '---------------------
                v_ACTUAL_AMT_PRICE = Nvl(a_INDIVIDUAL_PRICE, 0) - (Nvl(v_DISCOUNT_AMOUNT, 0) / v_QTY)
                v_TOTAL_AMOUNT = ROUND_VOHAMT(v_ACTUAL_AMT_PRICE * v_QTY)

                '---------------------

                '---------------------

                v_TAX_AMOUNT = ROUND_VOHAMT(v_TOTAL_AMOUNT * (Nvl(a_TAX_PERCENTAGE, 0) / 100))


                    '--------------------
                    v_NET_AMOUNT = Nvl(v_TOTAL_AMOUNT, 0) + Nvl(v_TAX_AMOUNT, 0)
                '--------------------
            End If

            '------------------------------------------

            '------------------------------------------PRICE WITH   TAX 
            If Nvl(a_PAYMENT_METHOD, 1) = 1 Then

                '---------------
                v_QTY = Nvl(a_QUENTITY, 0)
                v_DISCOUNT = Nvl(a_DISCOUNT_PERCENTAGE, 0) / 100
                '---------------

                ' ---------------
                If a_calc_disc_amt Then
                    v_DISCOUNT_AMOUNT = ROUND_VOHAMT(v_DISCOUNT * v_QTY * a_INDIVIDUAL_PRICE)
                End If

                ' ---------------

                '---------------
                v_ACTUAL_AMT_PRICE = a_INDIVIDUAL_PRICE - (Nvl(v_DISCOUNT_AMOUNT, 0) / v_QTY)
                v_TOTAL_AMOUNT = ROUND_VOHAMT(v_ACTUAL_AMT_PRICE * v_QTY)
                ' ---------------

                ' ---------------

                v_TAX_AMOUNT = ROUND_VOHAMT(v_TOTAL_AMOUNT - (v_TOTAL_AMOUNT / (1 + (Nvl(a_TAX_PERCENTAGE, 0) / 100))))

                    '---------------

                    '---------------
                    v_ACTUAL_AMT_PRICE = a_INDIVIDUAL_PRICE - (Nvl(v_DISCOUNT_AMOUNT, 0) / v_QTY) - (v_TAX_AMOUNT / v_QTY)
                v_TOTAL_AMOUNT = ROUND_VOHAMT(v_ACTUAL_AMT_PRICE * v_QTY)
                v_NET_AMOUNT = v_TOTAL_AMOUNT + Nvl(v_TAX_AMOUNT, 0)
                '---------------

            End If
            ' 	------------------------------------------PRICE FREE+ZEROO  TAX 
            If Nvl(a_PAYMENT_METHOD, 1) = 3 Or
                Nvl(a_PAYMENT_METHOD, 1) = 4 Then



                '		  ---------------
                v_QTY = Nvl(a_QUENTITY, 0)
                v_DISCOUNT = Nvl(a_DISCOUNT_PERCENTAGE, 0) / 100

                '---------------


                '---------------

                If a_calc_disc_amt Then
                    v_DISCOUNT_AMOUNT = ROUND_VOHAMT(v_DISCOUNT * v_QTY * a_INDIVIDUAL_PRICE)
                End If

                '---------------


                '---------------
                v_ACTUAL_AMT_PRICE = a_INDIVIDUAL_PRICE - (Nvl(v_DISCOUNT_AMOUNT, 0) / v_QTY)
                v_TOTAL_AMOUNT = ROUND_VOHAMT(v_ACTUAL_AMT_PRICE * v_QTY)
                '---------------


                '---------------

                v_TAX_AMOUNT = 0
                '---------------

                '---------------

                v_NET_AMOUNT = v_TOTAL_AMOUNT + v_TAX_AMOUNT

                ' ---------------

            End If
            '------------------------------------------ 

            '------------------------------------------ PRICE FREE+ZEROO  TAX 
            If Nvl(a_PAYMENT_METHOD, 1) = 5 Then
                '			---------------
                v_QTY = Nvl(a_QUENTITY, 0)
                v_DISCOUNT = Nvl(a_DISCOUNT_PERCENTAGE, 0) / 100

                '---------------


                '---------------

                If a_calc_disc_amt Then
                    v_DISCOUNT_AMOUNT = ROUND_VOHAMT(v_DISCOUNT * v_QTY * a_INDIVIDUAL_PRICE)
                End If

                ' ---------------

                '---------------
                v_ACTUAL_AMT_PRICE = a_INDIVIDUAL_PRICE - (Nvl(v_DISCOUNT_AMOUNT, 0) / v_QTY)
                v_TOTAL_AMOUNT = ROUND_VOHAMT(v_ACTUAL_AMT_PRICE * v_QTY)
                ' ---------------


                '	  	---------------

                v_TAX_AMOUNT = ROUND_VOHAMT(v_TOTAL_AMOUNT * (Nvl(a_TAX_PERCENTAGE, 0) / 100))

                    '			---------------

                    '			---------------
                    v_NET_AMOUNT = Nvl(v_TOTAL_AMOUNT, 0) + Nvl(v_TAX_AMOUNT, 0)
                '			---------------
            End If

            '----------------------

            '----------------------

            Dim v_INVOICE_CALC As New INVOICE_CALC

            v_INVOICE_CALC.ACTUAL_AMT_PRICE = v_ACTUAL_AMT_PRICE
            v_INVOICE_CALC.DISCOUNT = v_DISCOUNT
            v_INVOICE_CALC.DISCOUNT_AMOUNT = v_DISCOUNT_AMOUNT
            v_INVOICE_CALC.DISCOUNT_PERCENTAGE = a_DISCOUNT_PERCENTAGE
            v_INVOICE_CALC.INDIVIDUAL_PRICE = a_INDIVIDUAL_PRICE
            v_INVOICE_CALC.NET_AMOUNT = v_NET_AMOUNT
            v_INVOICE_CALC.QTY = v_QTY
            v_INVOICE_CALC.QUENTITY = a_QUENTITY
            v_INVOICE_CALC.TAX_AMOUNT = v_TAX_AMOUNT
            v_INVOICE_CALC.TOTAL_AMOUNT = v_TOTAL_AMOUNT


            Return v_INVOICE_CALC


        Catch ex As Exception
            Return New INVOICE_CALC
        End Try
    End Function

End Class
