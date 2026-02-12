<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGestion = New System.Windows.Forms.TabPage()
        Me.grpTipo = New System.Windows.Forms.GroupBox()
        Me.rbRevista = New System.Windows.Forms.RadioButton()
        Me.rbLibro = New System.Windows.Forms.RadioButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.grpDetalles = New System.Windows.Forms.GroupBox()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.lblPaginas = New System.Windows.Forms.Label()
        Me.txtPaginas = New System.Windows.Forms.TextBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.txtEdicion = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tabInventario = New System.Windows.Forms.TabPage()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.grpOperaciones = New System.Windows.Forms.GroupBox()
        Me.numStock = New System.Windows.Forms.NumericUpDown()
        Me.btnSumarStock = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.tabBusqueda = New System.Windows.Forms.TabPage()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        
        Me.tabControl1.SuspendLayout()
        Me.tabGestion.SuspendLayout()
        Me.grpTipo.SuspendLayout()
        Me.grpDetalles.SuspendLayout()
        Me.tabInventario.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOperaciones.SuspendLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBusqueda.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabGestion)
        Me.tabControl1.Controls.Add(Me.tabInventario)
        Me.tabControl1.Controls.Add(Me.tabBusqueda)
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(760, 480)
        Me.tabControl1.TabIndex = 0
        
        '
        'tabGestion
        '
        Me.tabGestion.Controls.Add(Me.grpTipo)
        Me.tabGestion.Controls.Add(Me.lblTitulo)
        Me.tabGestion.Controls.Add(Me.txtTitulo)
        Me.tabGestion.Controls.Add(Me.lblAnio)
        Me.tabGestion.Controls.Add(Me.txtAnio)
        Me.tabGestion.Controls.Add(Me.lblStock)
        Me.tabGestion.Controls.Add(Me.txtStock)
        Me.tabGestion.Controls.Add(Me.grpDetalles)
        Me.tabGestion.Controls.Add(Me.btnAgregar)
        Me.tabGestion.Location = New System.Drawing.Point(4, 22)
        Me.tabGestion.Name = "tabGestion"
        Me.tabGestion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGestion.Size = New System.Drawing.Size(752, 454)
        Me.tabGestion.TabIndex = 0
        Me.tabGestion.Text = "Gestión"
        Me.tabGestion.UseVisualStyleBackColor = True
        
        '
        'grpTipo
        '
        Me.grpTipo.Controls.Add(Me.rbRevista)
        Me.grpTipo.Controls.Add(Me.rbLibro)
        Me.grpTipo.Location = New System.Drawing.Point(20, 20)
        Me.grpTipo.Name = "grpTipo"
        Me.grpTipo.Size = New System.Drawing.Size(200, 50)
        Me.grpTipo.TabIndex = 0
        Me.grpTipo.TabStop = False
        Me.grpTipo.Text = "Tipo de Material"
        
        '
        'rbLibro
        '
        Me.rbLibro.AutoSize = True
        Me.rbLibro.Checked = True
        Me.rbLibro.Location = New System.Drawing.Point(20, 20)
        Me.rbLibro.Name = "rbLibro"
        Me.rbLibro.Size = New System.Drawing.Size(48, 17)
        Me.rbLibro.TabIndex = 0
        Me.rbLibro.TabStop = True
        Me.rbLibro.Text = "Libro"
        Me.rbLibro.UseVisualStyleBackColor = True
        
        '
        'rbRevista
        '
        Me.rbRevista.AutoSize = True
        Me.rbRevista.Location = New System.Drawing.Point(100, 20)
        Me.rbRevista.Name = "rbRevista"
        Me.rbRevista.Size = New System.Drawing.Size(61, 17)
        Me.rbRevista.TabIndex = 1
        Me.rbRevista.TabStop = True
        Me.rbRevista.Text = "Revista"
        Me.rbRevista.UseVisualStyleBackColor = True
        
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(20, 100)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(300, 20)
        Me.txtTitulo.TabIndex = 2
        
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(20, 80)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Título:"
        
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(340, 100)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(80, 20)
        Me.txtAnio.TabIndex = 3
        
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(340, 80)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnio.TabIndex = 13
        Me.lblAnio.Text = "Año:"
        
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(440, 100)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(80, 20)
        Me.txtStock.TabIndex = 4
        
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(440, 80)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(38, 13)
        Me.lblStock.TabIndex = 14
        Me.lblStock.Text = "Stock:"
        
        '
        'grpDetalles
        '
        Me.grpDetalles.Controls.Add(Me.lblAutor)
        Me.grpDetalles.Controls.Add(Me.txtAutor)
        Me.grpDetalles.Controls.Add(Me.lblGenero)
        Me.grpDetalles.Controls.Add(Me.txtGenero)
        Me.grpDetalles.Controls.Add(Me.lblPaginas)
        Me.grpDetalles.Controls.Add(Me.txtPaginas)
        Me.grpDetalles.Controls.Add(Me.lblMes)
        Me.grpDetalles.Controls.Add(Me.txtMes)
        Me.grpDetalles.Controls.Add(Me.lblEdicion)
        Me.grpDetalles.Controls.Add(Me.txtEdicion)
        Me.grpDetalles.Location = New System.Drawing.Point(20, 140)
        Me.grpDetalles.Name = "grpDetalles"
        Me.grpDetalles.Size = New System.Drawing.Size(500, 150)
        Me.grpDetalles.TabIndex = 5
        Me.grpDetalles.TabStop = False
        Me.grpDetalles.Text = "Detalles Específicos"
        
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(20, 30)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(35, 13)
        Me.lblAutor.TabIndex = 0
        Me.lblAutor.Text = "Autor:"
        
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(20, 50)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(200, 20)
        Me.txtAutor.TabIndex = 1
        
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(240, 30)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 2
        Me.lblGenero.Text = "Género:"
        
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(240, 50)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(150, 20)
        Me.txtGenero.TabIndex = 3
        
        '
        'lblPaginas
        '
        Me.lblPaginas.AutoSize = True
        Me.lblPaginas.Location = New System.Drawing.Point(410, 30)
        Me.lblPaginas.Name = "lblPaginas"
        Me.lblPaginas.Size = New System.Drawing.Size(48, 13)
        Me.lblPaginas.TabIndex = 4
        Me.lblPaginas.Text = "Páginas:"
        
        '
        'txtPaginas
        '
        Me.txtPaginas.Location = New System.Drawing.Point(410, 50)
        Me.txtPaginas.Name = "txtPaginas"
        Me.txtPaginas.Size = New System.Drawing.Size(60, 20)
        Me.txtPaginas.TabIndex = 5
        
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(20, 80)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 13)
        Me.lblMes.TabIndex = 6
        Me.lblMes.Text = "Mes:"
        Me.lblMes.Visible = False
        
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(20, 100)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(150, 20)
        Me.txtMes.TabIndex = 7
        Me.txtMes.Visible = False
        
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Location = New System.Drawing.Point(200, 80)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(45, 13)
        Me.lblEdicion.TabIndex = 8
        Me.lblEdicion.Text = "Edición:"
        Me.lblEdicion.Visible = False
        
        '
        'txtEdicion
        '
        Me.txtEdicion.Location = New System.Drawing.Point(200, 100)
        Me.txtEdicion.Name = "txtEdicion"
        Me.txtEdicion.Size = New System.Drawing.Size(80, 20)
        Me.txtEdicion.TabIndex = 9
        Me.txtEdicion.Visible = False
        
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(20, 310)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar al Inventario"
        Me.btnAgregar.UseVisualStyleBackColor = True
        
        '
        'tabInventario
        '
        Me.tabInventario.Controls.Add(Me.dgvInventario)
        Me.tabInventario.Controls.Add(Me.btnRefrescar)
        Me.tabInventario.Controls.Add(Me.grpOperaciones)
        Me.tabInventario.Location = New System.Drawing.Point(4, 22)
        Me.tabInventario.Name = "tabInventario"
        Me.tabInventario.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInventario.Size = New System.Drawing.Size(752, 454)
        Me.tabInventario.TabIndex = 1
        Me.tabInventario.Text = "Inventario"
        Me.tabInventario.UseVisualStyleBackColor = True
        
        '
        'dgvInventario
        '
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.AllowUserToDeleteRows = False
        Me.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(20, 60)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.ReadOnly = True
        Me.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.Size = New System.Drawing.Size(710, 280)
        Me.dgvInventario.TabIndex = 0
        
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(20, 20)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(100, 30)
        Me.btnRefrescar.TabIndex = 1
        Me.btnRefrescar.Text = "Refrescar Lista"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        
        '
        'grpOperaciones
        '
        Me.grpOperaciones.Controls.Add(Me.numStock)
        Me.grpOperaciones.Controls.Add(Me.btnSumarStock)
        Me.grpOperaciones.Controls.Add(Me.btnEliminar)
        Me.grpOperaciones.Location = New System.Drawing.Point(20, 360)
        Me.grpOperaciones.Name = "grpOperaciones"
        Me.grpOperaciones.Size = New System.Drawing.Size(710, 80)
        Me.grpOperaciones.TabIndex = 2
        Me.grpOperaciones.TabStop = False
        Me.grpOperaciones.Text = "Operaciones con Selección"
        
        '
        'numStock
        '
        Me.numStock.Location = New System.Drawing.Point(20, 30)
        Me.numStock.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numStock.Name = "numStock"
        Me.numStock.Size = New System.Drawing.Size(80, 20)
        Me.numStock.TabIndex = 0
        
        '
        'btnSumarStock
        '
        Me.btnSumarStock.Location = New System.Drawing.Point(110, 25)
        Me.btnSumarStock.Name = "btnSumarStock"
        Me.btnSumarStock.Size = New System.Drawing.Size(100, 30)
        Me.btnSumarStock.TabIndex = 1
        Me.btnSumarStock.Text = "Sumar Stock"
        Me.btnSumarStock.UseVisualStyleBackColor = True
        
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(600, 25)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar Item"
        Me.btnEliminar.UseVisualStyleBackColor = True
        
        '
        'tabBusqueda
        '
        Me.tabBusqueda.Controls.Add(Me.lblBuscar)
        Me.tabBusqueda.Controls.Add(Me.txtBuscar)
        Me.tabBusqueda.Controls.Add(Me.btnBuscar)
        Me.tabBusqueda.Controls.Add(Me.dgvResultados)
        Me.tabBusqueda.Location = New System.Drawing.Point(4, 22)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBusqueda.Size = New System.Drawing.Size(752, 454)
        Me.tabBusqueda.TabIndex = 2
        Me.tabBusqueda.Text = "Búsqueda"
        Me.tabBusqueda.UseVisualStyleBackColor = True
        
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(20, 30)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(87, 13)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar por título:"
        
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(120, 27)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(300, 20)
        Me.txtBuscar.TabIndex = 1
        
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(440, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(20, 70)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.Size = New System.Drawing.Size(710, 360)
        Me.dgvResultados.TabIndex = 3
        
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Form1"
        Me.Text = "Biblioteca Digital"
        Me.tabControl1.ResumeLayout(False)
        Me.tabGestion.ResumeLayout(False)
        Me.tabGestion.PerformLayout()
        Me.grpTipo.ResumeLayout(False)
        Me.grpTipo.PerformLayout()
        Me.grpDetalles.ResumeLayout(False)
        Me.grpDetalles.PerformLayout()
        Me.tabInventario.ResumeLayout(False)
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOperaciones.ResumeLayout(False)
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBusqueda.ResumeLayout(False)
        Me.tabBusqueda.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGestion As System.Windows.Forms.TabPage
    Friend WithEvents tabInventario As System.Windows.Forms.TabPage
    Friend WithEvents tabBusqueda As System.Windows.Forms.TabPage
    Friend WithEvents grpTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbRevista As System.Windows.Forms.RadioButton
    Friend WithEvents rbLibro As System.Windows.Forms.RadioButton
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents grpDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents txtPaginas As System.Windows.Forms.TextBox
    Friend WithEvents lblPaginas As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents txtEdicion As System.Windows.Forms.TextBox
    Friend WithEvents lblEdicion As System.Windows.Forms.Label
    Friend WithEvents dgvInventario As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents grpOperaciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSumarStock As System.Windows.Forms.Button
    Friend WithEvents numStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
End Class
