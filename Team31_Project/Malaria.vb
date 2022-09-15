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
' Class name: Malaria
' *****************************************************************
Public Class Malaria
    Inherits Disease

    Public Sub New(TotalPopulation As Integer, NumInfected As Integer)

        _TotPop = TotalPopulation
        _NumIn = NumInfected
        _Type = 2

    End Sub

End Class
