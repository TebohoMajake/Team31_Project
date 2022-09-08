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
' Class name: Disease
' *****************************************************************
Public MustInherit Class Disease


    Protected _TotPop As Integer
    Protected _NumIn As Integer
    Protected _Resources(3) As Resource
    Protected _Type As Integer

    Public Sub New()

        _Resources(1) = New Money
        _Resources(2) = New Doctor
        _Resources(3) = New Medication

    End Sub

    Public Function CalcRatio() As Double

        Return _NumIn / _TotPop

    End Function
End Class
