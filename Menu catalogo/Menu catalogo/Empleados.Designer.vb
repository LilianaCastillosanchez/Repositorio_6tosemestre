<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtPaterno = New System.Windows.Forms.TextBox()
        Me.TxtMaterno = New System.Windows.Forms.TextBox()
        Me.TxtDirec = New System.Windows.Forms.TextBox()
        Me.TxtRfc = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblPaterno = New System.Windows.Forms.Label()
        Me.LblMaterno = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblDirec = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblFecNac = New System.Windows.Forms.Label()
        Me.Lblrfc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpNac = New System.Windows.Forms.DateTimePicker()
        Me.DtpIngre = New System.Windows.Forms.DateTimePicker()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Lblidcategoria = New System.Windows.Forms.Label()
        Me.TxtIdcategoria = New System.Windows.Forms.TextBox()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Cmbcategoria = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnactualizar = New System.Windows.Forms.Button()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGaf = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFoto
        '
        Me.btnFoto.Location = New System.Drawing.Point(689, 211)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(176, 23)
        Me.btnFoto.TabIndex = 0
        Me.btnFoto.Text = "Foto"
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(16, 349)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(96, 23)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(146, 11)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(85, 20)
        Me.TxtId.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(12, 71)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(189, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtPaterno
        '
        Me.TxtPaterno.Location = New System.Drawing.Point(208, 71)
        Me.TxtPaterno.Name = "TxtPaterno"
        Me.TxtPaterno.Size = New System.Drawing.Size(206, 20)
        Me.TxtPaterno.TabIndex = 6
        '
        'TxtMaterno
        '
        Me.TxtMaterno.Location = New System.Drawing.Point(435, 71)
        Me.TxtMaterno.Name = "TxtMaterno"
        Me.TxtMaterno.Size = New System.Drawing.Size(200, 20)
        Me.TxtMaterno.TabIndex = 7
        '
        'TxtDirec
        '
        Me.TxtDirec.Location = New System.Drawing.Point(12, 147)
        Me.TxtDirec.Name = "TxtDirec"
        Me.TxtDirec.Size = New System.Drawing.Size(189, 20)
        Me.TxtDirec.TabIndex = 8
        '
        'TxtRfc
        '
        Me.TxtRfc.Location = New System.Drawing.Point(12, 213)
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(189, 20)
        Me.TxtRfc.TabIndex = 10
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(216, 147)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(198, 20)
        Me.TxtTel.TabIndex = 12
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(435, 147)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(200, 20)
        Me.TxtCorreo.TabIndex = 13
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(12, 12)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(91, 16)
        Me.LblId.TabIndex = 30
        Me.LblId.Text = "Id de usuario :"
        '
        'LblPaterno
        '
        Me.LblPaterno.AutoSize = True
        Me.LblPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaterno.Location = New System.Drawing.Point(213, 52)
        Me.LblPaterno.Name = "LblPaterno"
        Me.LblPaterno.Size = New System.Drawing.Size(110, 16)
        Me.LblPaterno.TabIndex = 31
        Me.LblPaterno.Text = "Apellido paterno:"
        '
        'LblMaterno
        '
        Me.LblMaterno.AutoSize = True
        Me.LblMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterno.Location = New System.Drawing.Point(432, 52)
        Me.LblMaterno.Name = "LblMaterno"
        Me.LblMaterno.Size = New System.Drawing.Size(113, 16)
        Me.LblMaterno.TabIndex = 32
        Me.LblMaterno.Text = "Apellido materno:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(13, 52)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(60, 16)
        Me.LblNombre.TabIndex = 33
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDirec
        '
        Me.LblDirec.AutoSize = True
        Me.LblDirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDirec.Location = New System.Drawing.Point(13, 118)
        Me.LblDirec.Name = "LblDirec"
        Me.LblDirec.Size = New System.Drawing.Size(68, 16)
        Me.LblDirec.TabIndex = 34
        Me.LblDirec.Text = "Direccion:"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(213, 118)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(65, 16)
        Me.lblTel.TabIndex = 35
        Me.lblTel.Text = "Telefono:"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.Location = New System.Drawing.Point(432, 118)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(52, 16)
        Me.LblCorreo.TabIndex = 36
        Me.LblCorreo.Text = "Correo:"
        '
        'LblFecNac
        '
        Me.LblFecNac.AutoSize = True
        Me.LblFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecNac.Location = New System.Drawing.Point(213, 184)
        Me.LblFecNac.Name = "LblFecNac"
        Me.LblFecNac.Size = New System.Drawing.Size(136, 16)
        Me.LblFecNac.TabIndex = 37
        Me.LblFecNac.Text = "Fecha de nacimiento:"
        '
        'Lblrfc
        '
        Me.Lblrfc.AutoSize = True
        Me.Lblrfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrfc.Location = New System.Drawing.Point(13, 184)
        Me.Lblrfc.Name = "Lblrfc"
        Me.Lblrfc.Size = New System.Drawing.Size(31, 16)
        Me.Lblrfc.TabIndex = 38
        Me.Lblrfc.Text = "Rfc:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Fecha de ingreso"
        '
        'DtpNac
        '
        Me.DtpNac.Location = New System.Drawing.Point(216, 213)
        Me.DtpNac.Name = "DtpNac"
        Me.DtpNac.Size = New System.Drawing.Size(198, 20)
        Me.DtpNac.TabIndex = 40
        '
        'DtpIngre
        '
        Me.DtpIngre.Location = New System.Drawing.Point(435, 213)
        Me.DtpIngre.Name = "DtpIngre"
        Me.DtpIngre.Size = New System.Drawing.Size(200, 20)
        Me.DtpIngre.TabIndex = 41
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(324, 349)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(96, 23)
        Me.Btnbuscar.TabIndex = 42
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Btnclose
        '
        Me.Btnclose.Location = New System.Drawing.Point(734, 349)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(81, 23)
        Me.Btnclose.TabIndex = 43
        Me.Btnclose.Text = "Cerrar"
        Me.Btnclose.UseVisualStyleBackColor = True
        '
        'Lblidcategoria
        '
        Me.Lblidcategoria.AutoSize = True
        Me.Lblidcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblidcategoria.Location = New System.Drawing.Point(247, 11)
        Me.Lblidcategoria.Name = "Lblidcategoria"
        Me.Lblidcategoria.Size = New System.Drawing.Size(82, 16)
        Me.Lblidcategoria.TabIndex = 44
        Me.Lblidcategoria.Text = "Id categoria "
        '
        'TxtIdcategoria
        '
        Me.TxtIdcategoria.Location = New System.Drawing.Point(365, 11)
        Me.TxtIdcategoria.Name = "TxtIdcategoria"
        Me.TxtIdcategoria.Size = New System.Drawing.Size(85, 20)
        Me.TxtIdcategoria.TabIndex = 45
        '
        'TxtLogin
        '
        Me.TxtLogin.Location = New System.Drawing.Point(12, 285)
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(189, 20)
        Me.TxtLogin.TabIndex = 46
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(220, 285)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(200, 20)
        Me.TxtPass.TabIndex = 47
        '
        'Cmbcategoria
        '
        Me.Cmbcategoria.FormattingEnabled = True
        Me.Cmbcategoria.Location = New System.Drawing.Point(435, 284)
        Me.Cmbcategoria.Name = "Cmbcategoria"
        Me.Cmbcategoria.Size = New System.Drawing.Size(200, 21)
        Me.Cmbcategoria.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.Location = New System.Drawing.Point(689, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Btnactualizar
        '
        Me.Btnactualizar.Location = New System.Drawing.Point(173, 349)
        Me.Btnactualizar.Name = "Btnactualizar"
        Me.Btnactualizar.Size = New System.Drawing.Size(96, 23)
        Me.Btnactualizar.TabIndex = 50
        Me.Btnactualizar.Text = "Actualizar"
        Me.Btnactualizar.UseVisualStyleBackColor = True
        '
        'Btnborrar
        '
        Me.Btnborrar.Location = New System.Drawing.Point(480, 349)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(96, 23)
        Me.Btnborrar.TabIndex = 51
        Me.Btnborrar.Text = "Borrar registro"
        Me.Btnborrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Contraseña"
        '
        'BtnGaf
        '
        Me.BtnGaf.Location = New System.Drawing.Point(719, 255)
        Me.BtnGaf.Name = "BtnGaf"
        Me.BtnGaf.Size = New System.Drawing.Size(106, 23)
        Me.BtnGaf.TabIndex = 54
        Me.BtnGaf.Text = "Gafette"
        Me.BtnGaf.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 417)
        Me.Controls.Add(Me.BtnGaf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnborrar)
        Me.Controls.Add(Me.Btnactualizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cmbcategoria)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.TxtIdcategoria)
        Me.Controls.Add(Me.Lblidcategoria)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.DtpIngre)
        Me.Controls.Add(Me.DtpNac)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lblrfc)
        Me.Controls.Add(Me.LblFecNac)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.LblDirec)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblMaterno)
        Me.Controls.Add(Me.LblPaterno)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.TxtRfc)
        Me.Controls.Add(Me.TxtDirec)
        Me.Controls.Add(Me.TxtMaterno)
        Me.Controls.Add(Me.TxtPaterno)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.btnFoto)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtPaterno As TextBox
    Friend WithEvents TxtMaterno As TextBox
    Friend WithEvents TxtDirec As TextBox
    Friend WithEvents TxtRfc As TextBox
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents LblPaterno As Label
    Friend WithEvents LblMaterno As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblDirec As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents LblFecNac As Label
    Friend WithEvents Lblrfc As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpNac As DateTimePicker
    Friend WithEvents DtpIngre As DateTimePicker
    Friend WithEvents Btnbuscar As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents Lblidcategoria As Label
    Friend WithEvents TxtIdcategoria As TextBox
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Cmbcategoria As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btnactualizar As Button
    Friend WithEvents Btnborrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGaf As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
