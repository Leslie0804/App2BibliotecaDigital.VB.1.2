Public MustInherit Class Material
    Public Property Id As Integer
    Public Property Título As String
    Public Property Año As Integer
    Public Property Stock As Integer
    Public Property Tipo As String

    Private Shared contador As Integer = 1

    Public Sub New(titulo As String, anio As Integer, stock As Integer)
        Id = contador
        contador += 1
        Me.Título = titulo
        Me.Año = anio
        Me.Stock = stock
    End Sub

    Public Sub ActualizarStock(cantidad As Integer)
        Stock += cantidad
    End Sub

    Public Overridable Function ObtenerInformacion() As String
        Return $"ID: {Id} - Tipo: {Tipo} - Título: {Título} - Año: {Año} - Stock: {Stock}"
    End Function
End Class
