﻿Option Strict On
Option Explicit On
Option Infer Off

' ***************************************************************** 
' Team Number: assigned to team 
' Team Member 1 Details: Majake, T (222027521) 
' Team Member 2 Details: Surname, Initials (Student #) 
' Team Member 3 Details: Surname, Initials (Student #) 
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: Medication 
' *****************************************************************
Public Class Medication
    Inherits Resource

    Public Overrides Function CalcAll(r As Double, t As Integer) As String
        Throw New NotImplementedException()
    End Function
End Class
