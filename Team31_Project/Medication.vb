Option Strict On
Option Explicit On
Option Infer Off

' ***************************************************************** 
' Team Number: assigned to team 
' Team Member 1 Details: Majake, T (222027521) 
' Team Member 2 Details: Makore, LR (222218101) 
' Team Member 3 Details: Surname, Initials (Student #) 
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: Medication 
' *****************************************************************
Public Class Medication
    Inherits Resource

    Public Overrides Function CalcAll(r As Double, t As Integer) As String
        Dim Num1 As Double


        If t = 1 Then
            'If the desease calling this function is HIV the calculations below will be run
            Num1 = r * 10
            Return CStr(Num1) + "kg"

        ElseIf t = 2 Then
            'If the desease calling this function is Malaria the calculations below will be run
            Num1 = r * 30
            Return CStr(Num1) + "kg"

        ElseIf t = 3 Then
            'If the desease calling this function is Ebola the calculations below will be run
            Num1 = r * 50
            Return CStr(Num1) + "Kg"

        Else
            Return "Error"
        End If

    End Function
End Class
