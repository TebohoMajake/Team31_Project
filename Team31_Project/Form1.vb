Option Strict On
Option Explicit On
Option Infer Off
Imports System.Globalization

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
    Private Grid As Integer
    Private SelectedC As Integer

    Private Sub PT(r As Integer, c As Integer, t As String)

        grdDisplay.Row = r
        grdDisplay.Col = c
        grdDisplay.Text = t

    End Sub

    Private Sub Grid1()

        grdDisplay.Rows = NumC + 1
        grdDisplay.Cols = 4


        PT(0, 0, "Number")
        PT(0, 1, "Country:")
        PT(0, 2, "Population:")
        PT(0, 3, "Infected:")
        If NumC = 0 Then

        Else
            For i As Integer = 1 To NumC

                PT(i, 0, CStr(i))
                PT(i, 1, Countries(i).Cityname)
                PT(i, 2, CStr(Countries(i).Totalpopulation))
                PT(i, 3, CStr(Countries(i).Numinfected))

            Next
        End If

        txtExplorer.Text = "Main page"
        Grid = 1

        btnBack.Enabled = False
        btnSelectC.Enabled = True
    End Sub

    Private Sub Grid2(c As Integer)

        grdDisplay.Rows = 10
        grdDisplay.Cols = 2

        PT(0, 0, Countries(c).Name)

        PT(2, 0, "Population:")
        PT(2, 1, CStr(Countries(c).Totalpopulation))

        PT(4, 0, "Number infected:")
        PT(4, 1, CStr(Countries(c).Numinfected))

        PT(6, 0, "Resource:")
        PT(7, 0, "Number of Doctors:")
        PT(7, 0, "Amount of Medication:")
        PT(7, 0, "Amount of Money:")

        PT(6, 1, "Quantity:")


        txtExplorer.Text = "Main page >> " + Countries(c).Name
        Grid = 2

        btnBack.Enabled = True
        btnSelectC.Enabled = False

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
        Dim HI, Mal, Ebo As Integer

        name = InputBox("What is the name of Country #" + CStr(C))
        cityname = InputBox("What is the name of the specific city we are monitoring in " + name + "?")
        totalpop = CInt(InputBox("What is the total population of " + name + "?"))
        HI = CInt(InputBox("How many people in " + name + " got diagnosed with HIV?"))
        Mal = CInt(InputBox("How many people in " + name + "got diagnosed with Malaria?"))
        Ebo = CInt(InputBox("How many people in " + name + "got diagnosed with Ebola?"))

        Countries(C) = New Country(name, cityname, totalpop, HI, Mal, Ebo)

    End Sub

    Private Sub btnSelectC_Click(sender As Object, e As EventArgs) Handles btnSelectC.Click

        Dim Chosen As Integer

        Chosen = CInt(InputBox("Which country do you wish to view? Please Enter the Country Number."))
        While Chosen > NumC Or 0 > Chosen
            MsgBox("Sorry, but Country number " + CStr(Chosen) + " does not exist.")
            Chosen = CInt(InputBox("Which country do you wish to view? Please Enter the Country Number."))
        End While

        SelectedC = Chosen
        Grid2(Chosen)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If Grid = 2 Then

            Grid1()

        ElseIf Grid = 3 Then

            Grid2(SelectedC)

        End If

    End Sub
End Class
