Public Class Revista
    Inherits Material

    Public Property NumeroEdicion As Integer
    Public Property Mes As String

    Public Sub New(titulo As String, anio As Integer, numeroEdicion As Integer, mes As String, stock As Integer)
        MyBase.New(titulo, anio, stock)
        Me.NumeroEdicion = numeroEdicion
        Me.Mes = mes
        Tipo = "Revista"
    End Sub

    Public Overrides Function ObtenerInformacion() As String
        Return MyBase.ObtenerInformacion() & $" - Edición: {NumeroEdicion} - Mes: {Mes}"
    End Function
End Class
