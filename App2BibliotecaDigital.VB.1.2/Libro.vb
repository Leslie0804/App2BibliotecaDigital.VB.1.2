Public Class Libro
    Inherits Material

    Public Property Autor As String
    Public Property Género As String
    Public Property Paginas As Integer

    Public Sub New(titulo As String, autor As String, genero As String, anio As Integer, stock As Integer, paginas As Integer)
        MyBase.New(titulo, anio, stock)
        Me.Autor = autor
        Me.Género = genero
        Me.Paginas = paginas
        Tipo = "Libro"
    End Sub

    Public Overrides Function ObtenerInformacion() As String
        Return MyBase.ObtenerInformacion() & $" - Autor: {Autor} - Género: {Género} - Páginas: {Paginas}"
    End Function
End Class
