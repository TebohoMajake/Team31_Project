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
' Class name: Medication 
' *****************************************************************
Public Class Medication
    Inherits Resource

    Public Overrides Function CalcAll(r As Double, t As Integer) As String
        Dim Num1 As Double


        If t = 1 Then
            'If the desease calling this function is HIV the calculations below will be run
            Num1 = r * 75
            Return CStr(Num1)

        ElseIf t = 2 Then
            'If the desease calling this function is Malaria the calculations below will be run
            Num1 = r * 25
            Return CStr(Num1)

        ElseIf t = 3 Then
            'If the desease calling this function is Ebola the calculations below will be run
            Num1 = r * 50
            Return CStr(Num1)

        Else
            Return "Error"
        End If

    End Function
End Class
