Public Class clsInstructor
    Private strProfID As String
    Private strProfFName As String
    Private strProfLname As String
    Private strProfPhone As String
    Private strProfDept As String

    Public Property profID As String
        Get
            Return strProfID
        End Get
        Set(value As String)
            strProfID = value
        End Set
    End Property


    Public Property profFName As String
        Get
            Return strProfFName
        End Get
        Set(value As String)
            strProfFName = value
        End Set
    End Property

    Public Property profLName As String
        Get
            Return strProfLname
        End Get
        Set(value As String)
            strProfLname = value
        End Set
    End Property

    Public Property profPhone As String
        Get
            Return strProfPhone
        End Get
        Set(value As String)
            strProfPhone = value
        End Set
    End Property

    Public Property profDept As String
        Get
            Return strProfDept
        End Get
        Set(value As String)
            strProfDept = value
        End Set
    End Property



End Class
