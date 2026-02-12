Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace App._2._2.BibliotecDigital
    Public Class Biblioteca
        ' Lista de materiales del sistema
        Private materiales As List(Of Material)

        Public Sub New()
            materiales = New List(Of Material)()
            ' Datos de prueba
            materiales.Add(New Libro("El principito", "Antoine de Saint-Exupéry", "Fabula", 1943, 10, 96))
            materiales.Add(New Revista("National Geographic", 2023, 150, "Enero", 50))
        End Sub

        ' Método para registrar un libro
        Public Sub AltaLibro(titulo As String, autor As String, genero As String, anio As Integer, stock As Integer, paginas As Integer)
            Dim libro As New Libro(titulo, autor, genero, anio, stock, paginas)
            materiales.Add(libro)
        End Sub

        ' Método para registrar una revista
        Public Sub AltaRevista(titulo As String, anio As Integer, numeroEdicion As Integer, mes As String, stock As Integer)
            Dim revista As New Revista(titulo, anio, numeroEdicion, mes, stock)
            materiales.Add(revista)
        End Sub

        ' Método para dar de baja un material por ID
        Public Function BajaMaterial(id As Integer) As Boolean
            Dim materialABorrar As Material = materiales.Find(Function(m) m.Id = id)
            If materialABorrar IsNot Nothing Then
                materiales.Remove(materialABorrar)
                Return True
            End If
            Return False
        End Function

        ' Método para consultar todo el inventario
        Public Function ObtenerTodo() As List(Of Material)
            Return materiales
        End Function

        ' Método para buscar material por título
        Public Function BuscarMaterial(termino As String) As List(Of Material)
            Return materiales.Where(Function(m) m.Título.ToLower().Contains(termino.ToLower())).ToList()
        End Function

        ' Método para actualizar stock de un material
        Public Function ActualizarStockMaterial(id As Integer, cantidad As Integer) As String
            Dim material As Material = materiales.Find(Function(m) m.Id = id)
            If material Is Nothing Then
                Return "Material no encontrado."
            End If

            ' Validar que el stock no sea negativo
            If material.Stock + cantidad < 0 Then
                Return $"Error: El stock resultante sería negativo. Stock actual: {material.Stock}"
            End If

            material.ActualizarStock(cantidad)
            Return "Stock actualizado correctamente."
        End Function
    End Class
End Namespace
