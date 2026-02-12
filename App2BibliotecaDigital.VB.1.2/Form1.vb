Public Class Form1
    Private biblioteca As New Biblioteca()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarInventario()
    End Sub

    Private Sub ActualizarInventario()
        dgvInventario.DataSource = Nothing
        dgvInventario.DataSource = biblioteca.ObtenerTodos()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        ActualizarInventario()
    End Sub

    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click
        Try
            Dim titulo As String = txtTituloLibro.Text
            Dim autor As String = txtAutorLibro.Text
            Dim genero As String = txtGeneroLibro.Text
            Dim anio As Integer = Integer.Parse(txtAnioLibro.Text)
            Dim stock As Integer = Integer.Parse(txtStockLibro.Text)
            Dim paginas As Integer = Integer.Parse(txtPaginasLibro.Text)

            Dim libro As New Libro(titulo, autor, genero, anio, stock, paginas)
            biblioteca.AgregarMaterial(libro)
            MessageBox.Show("Libro agregado correctamente.")
            ActualizarInventario()
            LimpiarCamposLibro()
        Catch ex As Exception
            MessageBox.Show("Error al agregar libro. Verifique los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarCamposLibro()
        txtTituloLibro.Clear()
        txtAutorLibro.Clear()
        txtGeneroLibro.Clear()
        txtAnioLibro.Clear()
        txtStockLibro.Clear()
        txtPaginasLibro.Clear()
    End Sub

    Private Sub btnAgregarRevista_Click(sender As Object, e As EventArgs) Handles btnAgregarRevista.Click
        Try
            Dim titulo As String = txtTituloRevista.Text
            Dim anio As Integer = Integer.Parse(txtAnioRevista.Text)
            Dim edicion As Integer = Integer.Parse(txtEdicionRevista.Text)
            Dim mes As String = txtMesRevista.Text
            Dim stock As Integer = Integer.Parse(txtStockRevista.Text)

            Dim revista As New Revista(titulo, anio, edicion, mes, stock)
            biblioteca.AgregarMaterial(revista)
            MessageBox.Show("Revista agregada correctamente.")
            ActualizarInventario()
            LimpiarCamposRevista()
        Catch ex As Exception
            MessageBox.Show("Error al agregar revista. Verifique los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarCamposRevista()
        txtTituloRevista.Clear()
        txtAnioRevista.Clear()
        txtEdicionRevista.Clear()
        txtMesRevista.Clear()
        txtStockRevista.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim termino As String = txtBusqueda.Text
        Dim resultados = biblioteca.BuscarPorTitulo(termino)
        dgvBusqueda.DataSource = Nothing
        dgvBusqueda.DataSource = resultados
        If resultados.Count = 0 Then
            MessageBox.Show("No se encontraron resultados.")
        End If
    End Sub

    Private Sub btnActualizarStock_Click(sender As Object, e As EventArgs) Handles btnActualizarStock.Click
        Try
            Dim id As Integer = Integer.Parse(txtIdUpdate.Text)
            Dim cantidad As Integer = Integer.Parse(txtCantidadUpdate.Text)

            Dim material = biblioteca.ObtenerPorId(id)
            If material IsNot Nothing Then
                biblioteca.ActualizarStock(id, cantidad)
                MessageBox.Show("Stock actualizado.")
                ActualizarInventario()
                ' Refrescar búsqueda si hay
                btnBuscar_Click(Nothing, Nothing)
            Else
                MessageBox.Show("Material no encontrado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar stock: " & ex.Message)
        End Try
    End Sub
End Class
