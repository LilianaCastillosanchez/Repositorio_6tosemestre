<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btntel = New System.Windows.Forms.Button()
        Me.btnDomicilio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnParaLlevar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtVentaID = New System.Windows.Forms.TextBox()
        Me.BtnVentaNueva = New System.Windows.Forms.Button()
        Me.gpbBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.gbDetalles = New System.Windows.Forms.GroupBox()
        Me.mskTxtTotal = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvVentaDetalles = New System.Windows.Forms.DataGridView()
        Me.txtTipoProd = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNumProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.gpbBuscarProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(31, 385)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLocal
        '
        Me.btnLocal.Location = New System.Drawing.Point(31, 195)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(106, 37)
        Me.btnLocal.TabIndex = 4
        Me.btnLocal.Text = "Consumo en local"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'btntel
        '
        Me.btntel.Location = New System.Drawing.Point(31, 253)
        Me.btntel.Name = "btntel"
        Me.btntel.Size = New System.Drawing.Size(106, 50)
        Me.btntel.TabIndex = 5
        Me.btntel.Text = "Telefono/recoger en local"
        Me.btntel.UseVisualStyleBackColor = True
        '
        'btnDomicilio
        '
        Me.btnDomicilio.Location = New System.Drawing.Point(31, 327)
        Me.btnDomicilio.Name = "btnDomicilio"
        Me.btnDomicilio.Size = New System.Drawing.Size(106, 23)
        Me.btnDomicilio.TabIndex = 6
        Me.btnDomicilio.Text = "Entrega a domicilio"
        Me.btnDomicilio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Seleccione tipo de venta"
        '
        'btnParaLlevar
        '
        Me.btnParaLlevar.Location = New System.Drawing.Point(31, 152)
        Me.btnParaLlevar.Name = "btnParaLlevar"
        Me.btnParaLlevar.Size = New System.Drawing.Size(106, 23)
        Me.btnParaLlevar.TabIndex = 3
        Me.btnParaLlevar.Text = "Para llevar"
        Me.btnParaLlevar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtVentaID)
        Me.Panel2.Controls.Add(Me.BtnVentaNueva)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(144, 87)
        Me.Panel2.TabIndex = 13
        '
        'TxtVentaID
        '
        Me.TxtVentaID.Location = New System.Drawing.Point(19, 53)
        Me.TxtVentaID.Name = "TxtVentaID"
        Me.TxtVentaID.Size = New System.Drawing.Size(106, 20)
        Me.TxtVentaID.TabIndex = 1
        '
        'BtnVentaNueva
        '
        Me.BtnVentaNueva.Location = New System.Drawing.Point(19, 12)
        Me.BtnVentaNueva.Name = "BtnVentaNueva"
        Me.BtnVentaNueva.Size = New System.Drawing.Size(106, 23)
        Me.BtnVentaNueva.TabIndex = 0
        Me.BtnVentaNueva.Text = "Venta Nueva"
        Me.BtnVentaNueva.UseVisualStyleBackColor = True
        '
        'gpbBuscarProducto
        '
        Me.gpbBuscarProducto.Controls.Add(Me.dgvProductos)
        Me.gpbBuscarProducto.Controls.Add(Me.TxtProducto)
        Me.gpbBuscarProducto.Location = New System.Drawing.Point(195, 12)
        Me.gpbBuscarProducto.Name = "gpbBuscarProducto"
        Me.gpbBuscarProducto.Size = New System.Drawing.Size(389, 131)
        Me.gpbBuscarProducto.TabIndex = 14
        Me.gpbBuscarProducto.TabStop = False
        Me.gpbBuscarProducto.Text = "Producto"
        '
        'dgvProductos
        '
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(6, 46)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(362, 79)
        Me.dgvProductos.TabIndex = 1
        '
        'TxtProducto
        '
        Me.TxtProducto.Location = New System.Drawing.Point(7, 20)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(361, 20)
        Me.TxtProducto.TabIndex = 0
        '
        'gbDetalles
        '
        Me.gbDetalles.Controls.Add(Me.mskTxtTotal)
        Me.gbDetalles.Controls.Add(Me.Label6)
        Me.gbDetalles.Controls.Add(Me.dgvVentaDetalles)
        Me.gbDetalles.Controls.Add(Me.txtTipoProd)
        Me.gbDetalles.Controls.Add(Me.txtCantidad)
        Me.gbDetalles.Controls.Add(Me.txtPrecio)
        Me.gbDetalles.Controls.Add(Me.txtNumProducto)
        Me.gbDetalles.Controls.Add(Me.Label4)
        Me.gbDetalles.Controls.Add(Me.Label3)
        Me.gbDetalles.Controls.Add(Me.Label2)
        Me.gbDetalles.Controls.Add(Me.txtNombreProducto)
        Me.gbDetalles.Location = New System.Drawing.Point(195, 174)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(389, 237)
        Me.gbDetalles.TabIndex = 15
        Me.gbDetalles.TabStop = False
        '
        'mskTxtTotal
        '
        Me.mskTxtTotal.Location = New System.Drawing.Point(274, 211)
        Me.mskTxtTotal.Name = "mskTxtTotal"
        Me.mskTxtTotal.Size = New System.Drawing.Size(94, 20)
        Me.mskTxtTotal.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total $ :"
        '
        'dgvVentaDetalles
        '
        Me.dgvVentaDetalles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvVentaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaDetalles.Location = New System.Drawing.Point(9, 79)
        Me.dgvVentaDetalles.Name = "dgvVentaDetalles"
        Me.dgvVentaDetalles.Size = New System.Drawing.Size(359, 115)
        Me.dgvVentaDetalles.TabIndex = 8
        '
        'txtTipoProd
        '
        Me.txtTipoProd.Location = New System.Drawing.Point(9, 53)
        Me.txtTipoProd.Name = "txtTipoProd"
        Me.txtTipoProd.Size = New System.Drawing.Size(49, 20)
        Me.txtTipoProd.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(296, 53)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(72, 20)
        Me.txtCantidad.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(190, 53)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'txtNumProducto
        '
        Me.txtNumProducto.Location = New System.Drawing.Point(84, 53)
        Me.txtNumProducto.Name = "txtNumProducto"
        Me.txtNumProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtNumProducto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Articulo :"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(6, 10)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(362, 20)
        Me.txtNombreProducto.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(599, 465)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbDetalles)
        Me.Controls.Add(Me.gpbBuscarProducto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDomicilio)
        Me.Controls.Add(Me.btntel)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.btnParaLlevar)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmVentas"
        Me.Text = "Punto_de_venta"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gpbBuscarProducto.ResumeLayout(False)
        Me.gpbBuscarProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalles.ResumeLayout(False)
        Me.gbDetalles.PerformLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLocal As Button
    Friend WithEvents btntel As Button
    Friend WithEvents btnDomicilio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnParaLlevar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtVentaID As TextBox
    Friend WithEvents BtnVentaNueva As Button
    Friend WithEvents gpbBuscarProducto As GroupBox
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents gbDetalles As GroupBox
    Friend WithEvents dgvVentaDetalles As DataGridView
    Friend WithEvents txtTipoProd As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNumProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents mskTxtTotal As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
