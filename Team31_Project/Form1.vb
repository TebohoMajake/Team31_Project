Option Strict On
Option Explicit On
Option Infer Off

' ***************************************************************** 
' Team Number: assigned to team 
' Team Member 1 Details: Majake, T (222027521) 
' Team Member 2 Details: Makore, LR (222218101) 
' Team Member 3 Details: Khumalo , G (222082358)
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: Form1
' *****************************************************************
Public Class frmDisease

    'Variables
    Private Countries() As Country
    Private NumC As Integer = 0
    Private Grid As Integer
    Private SelectedC As Integer

    'Place Text on the Grid
    Private Sub PT(r As Integer, c As Integer, t As String)

        grdDisplay.Row = r
        grdDisplay.Col = c
        grdDisplay.Text = t

    End Sub

    'The main grid displaying all the countries and general data
    Private Sub Grid1()

        grdDisplay.Rows = NumC + 1
        grdDisplay.Cols = 5


        PT(0, 0, "Number")
        PT(0, 1, "Country:")
        PT(0, 2, "Population:")
        PT(0, 3, "Infected:")
        PT(0, 4, "Ratio infected:")

        If NumC = 0 Then

        Else
            For i As Integer = 1 To NumC

                PT(i, 0, CStr(i))
                PT(i, 1, Countries(i).Name)
                PT(i, 2, CStr(Countries(i).Totalpopulation))
                PT(i, 3, CStr(Countries(i).Numinfected))
                PT(i, 4, CStr(Countries(i).CalcRatio) + "%")

            Next
        End If

        txtExplorer.Text = "Main page"
        Grid = 1

        btnBack.Enabled = False
        btnDI.Enabled = False
        btnSelectC.Enabled = True
    End Sub

    'The second grid which displays a specific country's data
    Private Sub Grid2(c As Integer)

        grdDisplay.Rows = 10
        grdDisplay.Cols = 2

        For col As Integer = 0 To 1

            For row As Integer = 0 To 9

                PT(row, col, "")

            Next row

        Next col

        PT(0, 0, Countries(c).Name)

        PT(2, 0, "Population:")
        PT(2, 1, CStr(Countries(c).Totalpopulation))

        PT(4, 0, "Number infected:")
        PT(4, 1, CStr(Countries(c).Numinfected))

        PT(6, 0, "Resource:")
        PT(7, 0, "Number of Doctors:")
        PT(7, 1, CStr(Countries(c).Resources(2)))

        PT(8, 0, "Amount of Medicine:")
        PT(8, 1, CStr(Countries(c).Resources(3)) + "kg")

        PT(9, 0, "Amount of Money:")
        PT(9, 1, "$" + CStr(Countries(c).Resources(1)))

        PT(6, 1, "Quantity:")


        txtExplorer.Text = "Main page >> " + Countries(c).Name
        Grid = 2

        btnBack.Enabled = True
        btnDI.Enabled = True
        btnSelectC.Enabled = False

    End Sub

    'Displays the stats specific to the diseases from one country
    Private Sub Grid3(c As Integer)

        grdDisplay.Rows = 6
        grdDisplay.Cols = 3

        PT(0, 0, Countries(c).Name)

        PT(2, 0, "Disease:")
        PT(2, 1, "Number infected:")
        PT(2, 2, "Percetage of whole population:")

        PT(3, 0, "HIV")
        PT(3, 1, CStr(Countries(c).Diseases(1).NumIn))
        PT(3, 2, Format(Countries(c).Diseases(1).CalcRatio * 100, "0") + "%")

        PT(4, 0, "Malaria")
        PT(4, 1, CStr(Countries(c).Diseases(2).NumIn))
        PT(4, 2, Format(Countries(c).Diseases(2).CalcRatio * 100, "0") + "%")

        PT(5, 0, "Ebola")
        PT(5, 1, CStr(Countries(c).Diseases(3).NumIn))
        PT(5, 2, Format(Countries(c).Diseases(3).CalcRatio * 100, "0") + "%")

        txtExplorer.Text = "Main page >> " + Countries(c).Name + " >> Disease Infomation"
        Grid = 3

        btnBack.Enabled = True
        btnDI.Enabled = False
        btnSelectC.Enabled = False

    End Sub

    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSelectC.Enabled = False
        btnDI.Enabled = False
        btnBack.Enabled = False

    End Sub

    'Add Country button
    Private Sub btnAddC_Click(sender As Object, e As EventArgs) Handles btnAddC.Click

        'Checks if the there was one Country entered in the program
        If NumC = 0 Then

            'Resizes the Countries Array to accomodate for the new country
            ReDim Countries(1)
            NumC += 1
            AskCInfo(NumC)
            Grid1()                 'Then it displays the new Country on the Grid
        Else

            'If there was alread one or more Country entered then it will do the following
            NumC += 1
            Dim TempArray(Countries.Length) As Country
            For c As Integer = 1 To Countries.Length - 1

                TempArray(c) = Countries(c)

            Next

            ReDim Countries(NumC)

            For c As Integer = 1 To TempArray.Length - 1

                Countries(c) = TempArray(c)

            Next

            AskCInfo(NumC)
            Grid1()
        End If

    End Sub

    'Subroutine to ask for countries information and store it
    Private Sub AskCInfo(C As Integer)

        Dim name As String
        Dim totalpop As Integer
        Dim HI, Mal, Ebo As Integer

        name = InputBox("What is the name of Country #" + CStr(C))
        totalpop = CInt(InputBox("What is the total population of " + name + "?"))
        HI = CInt(InputBox("How many people in " + name + " got diagnosed with HIV?"))
        Mal = CInt(InputBox("How many people in " + name + "got diagnosed with Malaria?"))
        Ebo = CInt(InputBox("How many people in " + name + "got diagnosed with Ebola?"))

        Countries(C) = New Country(name, totalpop, HI, Mal, Ebo)

    End Sub

    'Select Country button
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

    'Back Button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If Grid = 2 Then

            Grid1()

        ElseIf Grid = 3 Then

            Grid2(SelectedC)

        End If

    End Sub

    'View Disease Info button
    Private Sub btnDI_Click(sender As Object, e As EventArgs) Handles btnDI.Click

        Grid3(SelectedC)

    End Sub
End Class
