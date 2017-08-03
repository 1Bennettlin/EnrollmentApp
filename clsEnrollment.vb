Public Class clsEnrollment

    Private strBrocoID As String
    Private strCatalogId As String

    Public Property broncoID As String
        Get
            Return strBrocoID
        End Get
        Set(value As String)
            strBrocoID = value
        End Set
    End Property

    Public Property catalogID As String
        Get
            Return strCatalogId
        End Get
        Set(value As String)
            strCatalogId = value
        End Set
    End Property
End Class
