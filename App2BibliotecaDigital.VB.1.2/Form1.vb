Imports App2BibliotecaDigital.VB._1._2.App._2._2.BibliotecDigital

Public Class Form1
    Private biblioteca As New Biblioteca()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrid()
    End Sub

    ' --- GESTIÓN ---
    Private Sub rbLibro_CheckedChanged(sender As Object, e As EventArgs) Handles rbLibro.CheckedChanged
        If rbLibro.Checked Then
            MostrarCamposLibro(True)
        End If
    End Sub

    Private Sub rbRevista_CheckedChanged(sender As Object, e As EventArgs) Handles rbRevista.CheckedChanged
        If rbRevista.Checked Then
            MostrarCamposLibro(False)
        End If
    End Sub

    Private Sub MostrarCamposLibro(esLibro As Boolean)
        lblAutor.Visible = esLibro
        txtAutor.Visible = esLibro
        lblGenero.Visible = esLibro
        txtGenero.Visible = esLibro
        lblPaginas.Visible = esLibro
        txtPaginas.Visible = esLibro

        lblMes.Visible = Not esLibro
        txtMes.Visible = Not esLibro
        lblEdicion.Visible = Not esLibro
        txtEdicion.Visible = Not esLibro
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim titulo As String = txtTitulo.Text
            Dim anio As Integer = Integer.Parse(txtAnio.Text)
            Dim stock As Integer = Integer.Parse(txtStock.Text)

            If rbLibro.Checked Then
                Dim autor As String = txtAutor.Text
                Dim genero As String = txtGenero.Text
                Dim paginas As Integer = Integer.Parse(txtPaginas.Text)
                biblioteca.AltaLibro(titulo, autor, genero, anio, stock, paginas)
                MessageBox.Show("Libro agregado correctamente.")
            Else
                Dim mes As String = txtMes.Text
                Dim edicion As Integer = Integer.Parse(txtEdicion.Text)
                biblioteca.AltaRevista(titulo, anio, edicion, mes, stock)
                MessageBox.Show("Revista agregada correctamente.")
            End If
            LimpiarCampos()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show("Error al agregar: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtTitulo.Clear()
        txtAnio.Clear()
        txtStock.Clear()
        txtAutor.Clear()
        txtGenero.Clear()
        txtPaginas.Clear()
        txtMes.Clear()
        txtEdicion.Clear()
    End Sub

    ' --- INVENTARIO ---
    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        ActualizarGrid()
    End Sub

    Private Sub ActualizarGrid()
        Dim materiales = biblioteca.ObtenerTodo()
        dgvInventario.DataSource = Nothing
        dgvInventario.DataSource = materiales
        dgvInventario.Refresh()
    End Sub

    Private Sub btnSumarStock_Click(sender As Object, e As EventArgs) Handles btnSumarStock.Click
        If dgvInventario.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvInventario.SelectedRows(0).Cells("Id").Value)
            Dim cantidad As Integer = CInt(numStock.Value)
            Dim mensaje As String = biblioteca.ActualizarStockMaterial(id, cantidad)
            MessageBox.Show(mensaje)
            ActualizarGrid()
        Else
            MessageBox.Show("Seleccione un item de la lista.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvInventario.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvInventario.SelectedRows(0).Cells("Id").Value)
            If biblioteca.BajaMaterial(id) Then
                MessageBox.Show("Material eliminado.")
                ActualizarGrid()
            Else
                MessageBox.Show("No se pudo eliminar.")
            End If
        Else
            MessageBox.Show("Seleccione un item de la lista.")
        End If
    End Sub

    ' --- BÚSQUEDA ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim termino As String = txtBuscar.Text
        Dim resultados = biblioteca.BuscarMaterial(termino)
        dgvResultados.DataSource = Nothing
        dgvResultados.DataSource = resultados
        If resultados.Count = 0 Then
            MessageBox.Show("No se encontraron resultados.")
        End If
    End Sub
End Class
