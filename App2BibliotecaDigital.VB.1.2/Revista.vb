Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace App._2._2.BibliotecDigital
    ' Clase Revista que hereda de Material
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

        Public Overrides ReadOnly Property Detalles As String
            Get
                Return $"Edición: {NumeroEdicion} - Mes: {Mes}"
            End Get
        End Property
    End Class
End Namespace
