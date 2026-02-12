Imports System.Collections.Generic
Imports System.Linq

Public Class Biblioteca
    Private materiales As List(Of Material)

    Public Sub New()
        materiales = New List(Of Material)()
    End Sub

    Public Sub AgregarMaterial(material As Material)
        materiales.Add(material)
    End Sub

    Public Function ObtenerTodos() As List(Of Material)
        Return materiales
    End Function

    Public Function BuscarPorTitulo(termino As String) As List(Of Material)
        Return materiales.Where(Function(m) m.Título.ToLower().Contains(termino.ToLower())).ToList()
    End Function

    Public Sub ActualizarStock(id As Integer, cantidad As Integer)
        Dim material = materiales.Find(Function(m) m.Id = id)
        If material IsNot Nothing Then
            material.ActualizarStock(cantidad)
        End If
    End Sub

    Public Function ObtenerPorId(id As Integer) As Material
        Return materiales.Find(Function(m) m.Id = id)
    End Function
End Class
