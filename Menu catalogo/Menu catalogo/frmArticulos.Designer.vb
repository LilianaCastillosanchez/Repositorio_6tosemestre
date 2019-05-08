<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Catalogo_Articulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catalogo_Articulos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPrimero = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnterior = New System.Windows.Forms.ToolStripButton()
        Me.tsbSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.tsbUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TcLista = New System.Windows.Forms.TabPage()
        Me.tc2Detalles = New System.Windows.Forms.TabPage()
        Me.cmbVigencia = New System.Windows.Forms.ComboBox()
        Me.ndMinimo = New System.Windows.Forms.NumericUpDown()
        Me.ndMaximo = New System.Windows.Forms.NumericUpDown()
        Me.cmbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtCantidadExistente = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIDArticulo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tc2Detalles.SuspendLayout()
        CType(Me.ndMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGrabar, Me.tsbBorrar, Me.tsbEditar, Me.tsbCancelar, Me.ToolStripSeparator1, Me.tsbPrimero, Me.tsbAnterior, Me.tsbSiguiente, Me.tsbUltimo, Me.ToolStripLabel1, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(514, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(23, 22)
        Me.tsbNuevo.Text = "ToolStripButton1"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Text = "ToolStripButton2"
        '
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Text = "ToolStripButton3"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton4"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(23, 22)
        Me.tsbCancelar.Text = "ToolStripButton5"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbPrimero
        '
        Me.tsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrimero.Image = CType(resources.GetObject("tsbPrimero.Image"), System.Drawing.Image)
        Me.tsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrimero.Name = "tsbPrimero"
        Me.tsbPrimero.Size = New System.Drawing.Size(23, 22)
        Me.tsbPrimero.Text = "tsbPrimero"
        '
        'tsbAnterior
        '
        Me.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAnterior.Image = CType(resources.GetObject("tsbAnterior.Image"), System.Drawing.Image)
        Me.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnterior.Name = "tsbAnterior"
        Me.tsbAnterior.Size = New System.Drawing.Size(23, 22)
        Me.tsbAnterior.Text = "tsbAnterior"
        '
        'tsbSiguiente
        '
        Me.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSiguiente.Image = CType(resources.GetObject("tsbSiguiente.Image"), System.Drawing.Image)
        Me.tsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSiguiente.Name = "tsbSiguiente"
        Me.tsbSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.tsbSiguiente.Text = "tsbSiguiente"
        '
        'tsbUltimo
        '
        Me.tsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbUltimo.Image = CType(resources.GetObject("tsbUltimo.Image"), System.Drawing.Image)
        Me.tsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUltimo.Name = "tsbUltimo"
        Me.tsbUltimo.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSalir
        '
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(29, 22)
        Me.tsbSalir.Text = "Salir"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TcLista)
        Me.TabControl1.Controls.Add(Me.tc2Detalles)
        Me.TabControl1.Location = New System.Drawing.Point(27, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(455, 394)
        Me.TabControl1.TabIndex = 1
        '
        'TcLista
        '
        Me.TcLista.Location = New System.Drawing.Point(4, 22)
        Me.TcLista.Name = "TcLista"
        Me.TcLista.Padding = New System.Windows.Forms.Padding(3)
        Me.TcLista.Size = New System.Drawing.Size(447, 368)
        Me.TcLista.TabIndex = 0
        Me.TcLista.Text = "Lista"
        Me.TcLista.UseVisualStyleBackColor = True
        '
        'tc2Detalles
        '
        Me.tc2Detalles.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tc2Detalles.Controls.Add(Me.cmbVigencia)
        Me.tc2Detalles.Controls.Add(Me.ndMinimo)
        Me.tc2Detalles.Controls.Add(Me.ndMaximo)
        Me.tc2Detalles.Controls.Add(Me.cmbUnidadMedida)
        Me.tc2Detalles.Controls.Add(Me.txtPrecioVenta)
        Me.tc2Detalles.Controls.Add(Me.txtCantidadExistente)
        Me.tc2Detalles.Controls.Add(Me.txtCosto)
        Me.tc2Detalles.Controls.Add(Me.txtNombre)
        Me.tc2Detalles.Controls.Add(Me.txtIDArticulo)
        Me.tc2Detalles.Controls.Add(Me.Label9)
        Me.tc2Detalles.Controls.Add(Me.Label8)
        Me.tc2Detalles.Controls.Add(Me.Label7)
        Me.tc2Detalles.Controls.Add(Me.Label6)
        Me.tc2Detalles.Controls.Add(Me.Label5)
        Me.tc2Detalles.Controls.Add(Me.Label4)
        Me.tc2Detalles.Controls.Add(Me.Label3)
        Me.tc2Detalles.Controls.Add(Me.Label2)
        Me.tc2Detalles.Controls.Add(Me.Label1)
        Me.tc2Detalles.Controls.Add(Me.dgvArticulos)
        Me.tc2Detalles.Location = New System.Drawing.Point(4, 22)
        Me.tc2Detalles.Name = "tc2Detalles"
        Me.tc2Detalles.Padding = New System.Windows.Forms.Padding(3)
        Me.tc2Detalles.Size = New System.Drawing.Size(447, 368)
        Me.tc2Detalles.TabIndex = 1
        Me.tc2Detalles.Text = "Detalles"
        '
        'cmbVigencia
        '
        Me.cmbVigencia.FormattingEnabled = True
        Me.cmbVigencia.Location = New System.Drawing.Point(122, 171)
        Me.cmbVigencia.Name = "cmbVigencia"
        Me.cmbVigencia.Size = New System.Drawing.Size(111, 21)
        Me.cmbVigencia.TabIndex = 28
        '
        'ndMinimo
        '
        Me.ndMinimo.Location = New System.Drawing.Point(122, 92)
        Me.ndMinimo.Name = "ndMinimo"
        Me.ndMinimo.Size = New System.Drawing.Size(84, 20)
        Me.ndMinimo.TabIndex = 27
        '
        'ndMaximo
        '
        Me.ndMaximo.Location = New System.Drawing.Point(122, 118)
        Me.ndMaximo.Name = "ndMaximo"
        Me.ndMaximo.Size = New System.Drawing.Size(84, 20)
        Me.ndMaximo.TabIndex = 26
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.FormattingEnabled = True
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(122, 66)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(181, 21)
        Me.cmbUnidadMedida.TabIndex = 24
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(122, 227)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(111, 20)
        Me.txtPrecioVenta.TabIndex = 23
        '
        'txtCantidadExistente
        '
        Me.txtCantidadExistente.Location = New System.Drawing.Point(122, 195)
        Me.txtCantidadExistente.Name = "txtCantidadExistente"
        Me.txtCantidadExistente.Size = New System.Drawing.Size(111, 20)
        Me.txtCantidadExistente.TabIndex = 22
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(122, 144)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(111, 20)
        Me.txtCosto.TabIndex = 21
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(122, 41)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(181, 20)
        Me.txtNombre.TabIndex = 20
        '
        'txtIDArticulo
        '
        Me.txtIDArticulo.Location = New System.Drawing.Point(122, 10)
        Me.txtIDArticulo.Name = "txtIDArticulo"
        Me.txtIDArticulo.Size = New System.Drawing.Size(111, 20)
        Me.txtIDArticulo.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(6, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Precio venta : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(6, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cantidad Existente :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(10, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Vigencia :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(10, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Costo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(10, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Maximo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(10, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Minimo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Unidad de medida :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Articulo :"
        '
        'dgvArticulos
        '
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(0, 0)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.Size = New System.Drawing.Size(364, 262)
        Me.dgvArticulos.TabIndex = 0
        '
        'Catalogo_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(514, 457)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Catalogo_Articulos"
        Me.Text = "Catalogo_Articulos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tc2Detalles.ResumeLayout(False)
        Me.tc2Detalles.PerformLayout()
        CType(Me.ndMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbPrimero As ToolStripButton
    Friend WithEvents tsbAnterior As ToolStripButton
    Friend WithEvents tsbSiguiente As ToolStripButton
    Friend WithEvents tsbUltimo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TcLista As TabPage
    Friend WithEvents tc2Detalles As TabPage
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents ndMinimo As NumericUpDown
    Friend WithEvents ndMaximo As NumericUpDown
    Friend WithEvents cmbUnidadMedida As ComboBox
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtCantidadExistente As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIDArticulo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbVigencia As ComboBox
End Class
