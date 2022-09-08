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
' Class name: Form1
' *****************************************************************
Public Class frmDisease

    Private Countries() As Country
    Private NumC As Integer = 0

    Private Sub PT(r As Integer, c As Integer, t As String)

        grdDisplay.Row = r
        grdDisplay.Col = c
        grdDisplay.Text = t

    End Sub

    Private Sub Grid1()

        grdDisplay.Rows = NumC + 1
        grdDisplay.Cols = 3

        PT(0, 0, "Country:")
        PT(0, 1, "Population:")
        PT(0, 2, "Infected:")
        If NumC = 0 Then

        Else
            For i As Integer = 1 To NumC

                PT(i, 0, Countries(i).Cityname)
                PT(i, 1, CStr(Countries(i).Totalpopulation))
                PT(i, 2, CStr(Countries(i).Numinfected))

            Next
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSelectC.Enabled = False
        btnBack.Enabled = False

    End Sub

    Private Sub btnAddC_Click(sender As Object, e As EventArgs) Handles btnAddC.Click

        If NumC = 0 Then

            ReDim Countries(1)
            NumC += 1
            AskCInfo(NumC)
            Grid1()
        Else

            NumC += 1
            Dim TempArray(Countries.Length) As Country
            For c As Integer = 1 To Countries.Length

                TempArray(c) = Countries(c)

            Next

            ReDim Countries(NumC)

            For c As Integer = 1 To TempArray.Length

                Countries(c) = TempArray(c)

            Next

            AskCInfo(NumC)
            Grid1()
        End If

    End Sub

    Private Sub AskCInfo(C As Integer)

        Dim name As String
        Dim cityname As String
        Dim totalpop As Integer
        Dim numinfected As Integer

        name = InputBox("What is the name of Country #" + CStr(C))
        cityname = InputBox("What is the name of the specific city we are monitoring in " + name + "?")
        totalpop = CInt(InputBox("What is the total population of " + name + "?"))
        numinfected = CInt(InputBox("How many people in " + name + " have been infected by at least on of the monitored diseases?"))

        Countries(C) = New Country(name, cityname, totalpop, numinfected)

    End Sub
End Class
