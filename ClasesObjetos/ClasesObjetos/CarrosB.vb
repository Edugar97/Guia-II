Public Class CarrosB
    Private ValorMarca As String
    Public Property Marca() As String
        Get
            Return ValorMarca
        End Get
        Set(ByVal value As String)
            ValorMarca = value
        End Set
    End Property
End Class
