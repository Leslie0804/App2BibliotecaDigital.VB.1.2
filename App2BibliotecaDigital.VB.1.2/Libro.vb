Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace App._2._2.BibliotecDigital
    ' Clase Libro que hereda de Material
    Public Class Libro
        Inherits Material

        Public Property Autor As String
        Public Property Género As String  ' Clasificación del libro
        Public Property Paginas As Integer

        Public Sub New(titulo As String, autor As String, genero As String, anio As Integer, stock As Integer, paginas As Integer)
            MyBase.New(titulo, anio, stock)
            Me.Autor = autor
            Me.Género = genero
            Me.Paginas = paginas
            Tipo = "Libro"
        End Sub

        Public Overrides ReadOnly Property Detalles As String
            Get
                Return $"Autor: {Autor} - Género: {Género} - Págs: {Paginas}"
            End Get
        End Property
    End Class
End Namespace
