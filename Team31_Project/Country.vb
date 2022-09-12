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
' Class name: Country 
' *****************************************************************
Public Class Country
    'Attributes
    Private _Name As String
    Private _CityName As String
    Private _TotalPopulation As Integer
    Private _Diseases(3) As Disease

    'Property Methods
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Cityname() As String
        Get
            Return _CityName
        End Get
        Set(value As String)
            _CityName = value
        End Set
    End Property

    Public Property Totalpopulation() As Integer
        Get
            Return _TotalPopulation
        End Get
        Set(value As Integer)
            _TotalPopulation = value
        End Set
    End Property

    Public ReadOnly Property Numinfected() As Integer
        Get
            Return CalcInf()
        End Get
    End Property

    Public Property Diseases(index As Integer) As Disease
        Get
            Return _Diseases(index)
        End Get
        Set(value As Disease)
            _Diseases(index) = value
        End Set
    End Property

    'Constructor
    Public Sub New(name As String, cityname As String, totalpop As Integer, HI As Integer, Mal As Integer, Ebo As Integer)
        _Name = name
        _CityName = cityname
        _TotalPopulation = totalpop

        _Diseases(1) = New HIV(_TotalPopulation, HI)
        _Diseases(2) = New Malaria(_TotalPopulation, Mal)
        _Diseases(3) = New Ebola(_TotalPopulation, Ebo)

    End Sub

    Private Function CalcInf() As Integer

        Dim Answer As Integer

        For d As Integer = 1 To 3

            Answer += Diseases(d).NumIn

        Next

        Return Answer

    End Function
End Class
