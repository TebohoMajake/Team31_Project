Option Strict On
Option Explicit On
Option Infer Off

' ***************************************************************** 
' Team Number: assigned to team 
' Team Member 1 Details: Majake, T (222027521) 
' Team Member 2 Details: Makore, LR (222218101) 
' Team Member 3 Details: Khumalo , G (222082358)
' Team Member 4 Details: Mbewe, K (221176553) 
' Practical: Team Project 
' Class name: Doctor 
' *****************************************************************
Public Class Doctor
    Inherits Resource


    Public Overrides Function CalcAll(r As Double, t As Integer) As String

        Dim Num1 As Double
        Dim Num2 As Double
        Dim Num3 As String

        If t = 1 Then
            'If the desease calling this function is HIV the calculations below will be run

            Num1 = r * 100                       'This means that the ratio of HIV will be multiplied by 50
            Num2 = Math.Round(Num1, 1)          'This then rounds up the double value to get an integer 
            Num3 = Format(Num2, "0")           'This then formats the value into string that can be returned

        ElseIf t = 2 Then
            'If the desease calling this function is Malaria the calculations below will be run

            Num1 = r * 35                    'This multiplies the ratio of Malaria by 75
            Num2 = Math.Round(Num1, 1)          'This the rounds up the double value to get an integer
            Num3 = Format(Num2, "0")            'This then formats the value into string

        ElseIf t = 3 Then
            'If the desease calling this function is Ebola the calculations below will be run

            Num1 = r * 60                     'This multiplies the ratio of Malaria by 100
            Num2 = Math.Round(Num1, 1)          'This the rounds up the double value to get an integer
            Num3 = Format(Num2, "0")            'This then formats the value into string

        Else
            'If there type is not 1, 2 or 3 then an error message will be returned
            Num3 = "Error"

        End If

        Return Num3
    End Function
End Class
