Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace App._2._2.BibliotecDigital
    Public MustInherit Class Material
        Public Property Id As Integer
        Public Property Título As String
        Public Property Año As Integer
        Public Property Stock As Integer
        Public Property Tipo As String

        Private Shared contador As Integer = 1

        Public Sub New(titulo As String, año As Integer, stock As Integer)
            Id = contador
            contador += 1
            Me.Título = titulo
            Me.Año = año
            Me.Stock = stock
        End Sub

        Public Sub ActualizarStock(cantidad As Integer)
            Stock += cantidad
        End Sub

        Public Overridable ReadOnly Property Detalles As String
            Get
                Return $"{Tipo}: {Título} ({Año})"
            End Get
        End Property
    End Class
End Namespace
