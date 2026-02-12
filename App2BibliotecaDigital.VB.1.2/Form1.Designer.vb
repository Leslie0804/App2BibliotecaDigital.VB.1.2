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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtPaginasLibro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStockLibro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnioLibro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGeneroLibro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAutorLibro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTituloLibro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarLibro = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtStockRevista = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMesRevista = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEdicionRevista = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAnioRevista = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTituloRevista = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAgregarRevista = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIdUpdate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCantidadUpdate = New System.Windows.Forms.TextBox()
        Me.btnActualizarStock = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnRefrescar)
        Me.TabPage1.Controls.Add(Me.dgvInventario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(8, 6)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(776, 383)
        Me.dgvInventario.TabIndex = 0
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(8, 395)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(776, 23)
        Me.btnRefrescar.TabIndex = 1
        Me.btnRefrescar.Text = "Refrescar Inventario"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAgregarLibro)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtPaginasLibro)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtStockLibro)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtAnioLibro)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtGeneroLibro)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtAutorLibro)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtTituloLibro)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agregar Libro"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtPaginasLibro
        '
        Me.txtPaginasLibro.Location = New System.Drawing.Point(100, 160)
        Me.txtPaginasLibro.Name = "txtPaginasLibro"
        Me.txtPaginasLibro.Size = New System.Drawing.Size(100, 20)
        Me.txtPaginasLibro.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Páginas:"
        '
        'txtStockLibro
        '
        Me.txtStockLibro.Location = New System.Drawing.Point(100, 134)
        Me.txtStockLibro.Name = "txtStockLibro"
        Me.txtStockLibro.Size = New System.Drawing.Size(100, 20)
        Me.txtStockLibro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stock:"
        '
        'txtAnioLibro
        '
        Me.txtAnioLibro.Location = New System.Drawing.Point(100, 108)
        Me.txtAnioLibro.Name = "txtAnioLibro"
        Me.txtAnioLibro.Size = New System.Drawing.Size(100, 20)
        Me.txtAnioLibro.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Año:"
        '
        'txtGeneroLibro
        '
        Me.txtGeneroLibro.Location = New System.Drawing.Point(100, 82)
        Me.txtGeneroLibro.Name = "txtGeneroLibro"
        Me.txtGeneroLibro.Size = New System.Drawing.Size(200, 20)
        Me.txtGeneroLibro.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Género:"
        '
        'txtAutorLibro
        '
        Me.txtAutorLibro.Location = New System.Drawing.Point(100, 56)
        Me.txtAutorLibro.Name = "txtAutorLibro"
        Me.txtAutorLibro.Size = New System.Drawing.Size(200, 20)
        Me.txtAutorLibro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Autor:"
        '
        'txtTituloLibro
        '
        Me.txtTituloLibro.Location = New System.Drawing.Point(100, 30)
        Me.txtTituloLibro.Name = "txtTituloLibro"
        Me.txtTituloLibro.Size = New System.Drawing.Size(200, 20)
        Me.txtTituloLibro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título:"
        '
        'btnAgregarLibro
        '
        Me.btnAgregarLibro.Location = New System.Drawing.Point(100, 200)
        Me.btnAgregarLibro.Name = "btnAgregarLibro"
        Me.btnAgregarLibro.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregarLibro.TabIndex = 12
        Me.btnAgregarLibro.Text = "Agregar Libro"
        Me.btnAgregarLibro.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnAgregarRevista)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.txtStockRevista)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtMesRevista)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txtEdicionRevista)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txtAnioRevista)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.txtTituloRevista)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Agregar Revista"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtStockRevista
        '
        Me.txtStockRevista.Location = New System.Drawing.Point(100, 134)
        Me.txtStockRevista.Name = "txtStockRevista"
        Me.txtStockRevista.Size = New System.Drawing.Size(100, 20)
        Me.txtStockRevista.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Stock:"
        '
        'txtMesRevista
        '
        Me.txtMesRevista.Location = New System.Drawing.Point(100, 108)
        Me.txtMesRevista.Name = "txtMesRevista"
        Me.txtMesRevista.Size = New System.Drawing.Size(100, 20)
        Me.txtMesRevista.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Mes:"
        '
        'txtEdicionRevista
        '
        Me.txtEdicionRevista.Location = New System.Drawing.Point(100, 82)
        Me.txtEdicionRevista.Name = "txtEdicionRevista"
        Me.txtEdicionRevista.Size = New System.Drawing.Size(100, 20)
        Me.txtEdicionRevista.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Edición:"
        '
        'txtAnioRevista
        '
        Me.txtAnioRevista.Location = New System.Drawing.Point(100, 56)
        Me.txtAnioRevista.Name = "txtAnioRevista"
        Me.txtAnioRevista.Size = New System.Drawing.Size(100, 20)
        Me.txtAnioRevista.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Año:"
        '
        'txtTituloRevista
        '
        Me.txtTituloRevista.Location = New System.Drawing.Point(100, 30)
        Me.txtTituloRevista.Name = "txtTituloRevista"
        Me.txtTituloRevista.Size = New System.Drawing.Size(200, 20)
        Me.txtTituloRevista.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Título:"
        '
        'btnAgregarRevista
        '
        Me.btnAgregarRevista.Location = New System.Drawing.Point(100, 180)
        Me.btnAgregarRevista.Name = "btnAgregarRevista"
        Me.btnAgregarRevista.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregarRevista.TabIndex = 10
        Me.btnAgregarRevista.Text = "Agregar Revista"
        Me.btnAgregarRevista.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.txtBusqueda)
        Me.TabPage4.Controls.Add(Me.btnBuscar)
        Me.TabPage4.Controls.Add(Me.dgvBusqueda)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(792, 424)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Buscar / Actualizar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Location = New System.Drawing.Point(8, 45)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(776, 250)
        Me.dgvBusqueda.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(240, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(60, 18)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(170, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Título:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnActualizarStock)
        Me.GroupBox1.Controls.Add(Me.txtCantidadUpdate)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtIdUpdate)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actualizar Stock"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ID Material:"
        '
        'txtIdUpdate
        '
        Me.txtIdUpdate.Location = New System.Drawing.Point(100, 27)
        Me.txtIdUpdate.Name = "txtIdUpdate"
        Me.txtIdUpdate.Size = New System.Drawing.Size(60, 20)
        Me.txtIdUpdate.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Cantidad:"
        '
        'txtCantidadUpdate
        '
        Me.txtCantidadUpdate.Location = New System.Drawing.Point(100, 57)
        Me.txtCantidadUpdate.Name = "txtCantidadUpdate"
        Me.txtCantidadUpdate.Size = New System.Drawing.Size(60, 20)
        Me.txtCantidadUpdate.TabIndex = 3
        '
        'btnActualizarStock
        '
        Me.btnActualizarStock.Location = New System.Drawing.Point(180, 40)
        Me.btnActualizarStock.Name = "btnActualizarStock"
        Me.btnActualizarStock.Size = New System.Drawing.Size(100, 30)
        Me.btnActualizarStock.TabIndex = 4
        Me.btnActualizarStock.Text = "Actualizar Stock"
        Me.btnActualizarStock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Biblioteca Digital"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTituloLibro As TextBox
    Friend WithEvents txtPaginasLibro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStockLibro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAnioLibro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGeneroLibro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAutorLibro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregarLibro As Button
    Friend WithEvents btnAgregarRevista As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStockRevista As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMesRevista As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEdicionRevista As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAnioRevista As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTituloRevista As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvBusqueda As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnActualizarStock As Button
    Friend WithEvents txtCantidadUpdate As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtIdUpdate As TextBox
    Friend WithEvents Label13 As Label
End Class
