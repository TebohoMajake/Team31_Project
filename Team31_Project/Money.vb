Option Strict On
Option Explicit On
Option Infer Off

' ***************************************************************** 
' Team Number: assigned to team 
' Team Member 1 Details: Majake, T (222027521) 
' Team Member 2 Details: Surname, Initials (Student #) 
' Team Member 3 Details: Surname, Initials (Student #) 
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: Money 
' *****************************************************************
Public Class Money
    Inherits Resource

    Public Overrides Function CalcAll(r As Double, t As Integer) As String

        Dim Num1 As Double

        If t = 1 Then
            'If the desease calling this function is HIV the calculations below will be run
            Num1 = r * 100000
            Return "R" + CStr(Num1)

        ElseIf t = 2 Then
            'If the desease calling this function is Malaria the calculations below will be run
            Num1 = r * 150000
            Return "R" + CStr(Num1)

        ElseIf t = 3 Then
            'If the desease calling this function is Ebola the calculations below will be run
            Num1 = r * 200000
            Return "R" + CStr(Num1)

        Else
            Return "Error"
        End If

    End Function
End Class
