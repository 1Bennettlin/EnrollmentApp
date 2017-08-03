Public Class clsCourse
    Private strCourseID As String
    Private strDescrip As String
    Private strUnit As String


    Public Property courseID As String
        Get
            Return strCourseID
        End Get
        Set(value As String)
            strCourseID = value
        End Set
    End Property

    Public Property decript As String
        Get
            Return strDescrip
        End Get
        Set(value As String)
            strDescrip = value
        End Set
    End Property

    Public Property units As String

        Get
            Return strUnit

        End Get
        Set(value As String)
            strUnit = value
        End Set
    End Property
End Class
