Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Empleados
    Dim verfoto As String
    Private Sub EMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCategoria()
    End Sub
    Public Sub LlenarCategoria()
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "Select Id_Categoria, Nombre_Cat from Categoria Order by Nombre_Cat"
        Comm.CommandType = CommandType.Text
        Dim sqlAd As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCategoria As New DataTable()
        sqlAd.Fill(tblCategoria)
        Cmbcategoria.ValueMember = "Id_Categoria"
        Cmbcategoria.DisplayMember = "Nombre_Cat"
        Cmbcategoria.DataSource = tblCategoria

    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString().Trim() <> "" Then verfoto = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(verfoto)

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Comm As New SqlCommand
        Comm.Connection = ConnSql
        Comm.CommandText = "Insert into Empleados (Id_Usuario, Nombre, A_Paterno, A_Materno, Direccion, Tel, E_mail, F_Nac, Rfc, F_Ingreso, Id_Categoria, Foto)" _
    & "Values (@Id_Usuario, @Nombre, @A_Paterno, @A_Materno, @Direccion, @Tel, @E_mail, @F_Nac, @Rfc, @F_Ingreso, @Id_Categoria, @Foto)"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = TxtId.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = TxtNombre.Text.ToString()
        Comm.Parameters.Add("@A_Paterno", SqlDbType.NChar, 30).Value = TxtPaterno.Text.ToString()
        Comm.Parameters.Add("@A_Materno", SqlDbType.NChar, 30).Value = TxtMaterno.Text.ToString()
        Comm.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = TxtDirec.Text.ToString()
        Comm.Parameters.Add("@Tel", SqlDbType.NChar, 12).Value = TxtTel.Text.ToString()
        Comm.Parameters.Add("@E_mail", SqlDbType.VarChar, 50).Value = TxtCorreo.Text.ToString()
        Comm.Parameters.Add("@F_Nac", SqlDbType.Date).Value = DtpNac.Text.ToString()
        Comm.Parameters.Add("@Rfc", SqlDbType.NChar, 30).Value = TxtRfc.Text.ToString()
        Comm.Parameters.Add("@F_Ingreso", SqlDbType.Date).Value = DtpIngre.Text.ToString()
        Comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 8).Value = TxtIdcategoria.Text.ToString()
        Comm.Parameters.Add("@Foto", SqlDbType.NVarChar, 150).Value = OpenFileDialog1.FileName.ToString().Trim

        Comm.ExecuteNonQuery()

        MessageBox.Show("Registro agregado!!")

        Comm.CommandText = "Insert into Acceso (Id_Usuario,Login,Password)" _
        & "Values(@Id,@Login,@Password)"
        Comm.Parameters.Add("@Id", SqlDbType.NChar, 10).Value = TxtId.Text.ToString()
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 25).Value = TxtLogin.Text.ToString()
        Comm.Parameters.Add("@Password", SqlDbType.NChar, 35).Value = TxtPass.Text.ToString()
        Comm.ExecuteNonQuery()


    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcategoria.SelectedIndexChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "Select Empleados.*, Acceso.Login, Acceso.Password from Empleados inner join Acceso" _
            & " on Empleados.Id_Usuario=Acceso.Id_Usuario where Empleados.Id_Usuario=@id"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@id", SqlDbType.NChar, 10).Value = TxtId.Text.ToString()
        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                TxtId.Text = DReader("Id_Usuario")
                Cmbcategoria.SelectedValue = DReader("Id_Categoria")

                If Not DReader.IsDBNull(DReader.GetOrdinal("Foto")) Then
                    PictureBox1.Image = Image.FromFile(DReader("Foto"))

                    TxtNombre.Text = DReader("Nombre")

                    TxtPaterno.Text = DReader.GetString(2)
                    TxtMaterno.Text = DReader.GetString(3)
                    TxtDirec.Text = DReader.GetString(4)
                    TxtTel.Text = DReader.GetValue(5).ToString()
                    TxtCorreo.Text = DReader.GetString(6)
                    DtpNac.Text = DReader.GetValue(7).ToString
                    TxtRfc.Text = DReader.GetString(8)
                    DtpIngre.Text = DReader.GetValue(9).ToString
                    TxtIdcategoria.Text = DReader.GetString(10)
                    TxtLogin.Text = DReader("Login")
                    TxtPass.Text = DReader("Password")

                Else
                    PictureBox1.Image = Nothing
                End If



            End While
            DReader.Close()

        End If


    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btnactualizar_Click(sender As Object, e As EventArgs) Handles Btnactualizar.Click
        Dim Comm As New SqlCommand
        Comm.Connection = ConnSql
        Comm.CommandText = "Update Empleados set Nombre=@Nombre, A_Paterno=@A_Paterno, A_Materno=@A_Materno, Direccion=@Direccion, Tel=@Tel, E_mail=@E_mail, 
            F_Nac=@F_Nac, Rfc=@Rfc, F_Ingreso=@F_Ingreso, Id_Categoria=@Id_Categoria, Foto=@Foto WHERE Id_Usuario=@Id_Usuario"


        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = TxtId.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = TxtNombre.Text.ToString()
        Comm.Parameters.Add("@A_Paterno", SqlDbType.NChar, 30).Value = TxtPaterno.Text.ToString()
        Comm.Parameters.Add("@A_Materno", SqlDbType.NChar, 30).Value = TxtMaterno.Text.ToString()
        Comm.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = TxtDirec.Text.ToString()
        Comm.Parameters.Add("@Tel", SqlDbType.NChar, 12).Value = TxtTel.Text.ToString()
        Comm.Parameters.Add("@E_mail", SqlDbType.VarChar, 50).Value = TxtCorreo.Text.ToString()
        Comm.Parameters.Add("@F_Nac", SqlDbType.Date).Value = DtpNac.Text.ToString()
        Comm.Parameters.Add("@Rfc", SqlDbType.NChar, 30).Value = TxtRfc.Text.ToString()
        Comm.Parameters.Add("@F_Ingreso", SqlDbType.Date).Value = DtpIngre.Text.ToString()
        Comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 8).Value = TxtIdcategoria.Text.ToString()
        Comm.Parameters.Add("@Foto", SqlDbType.NVarChar, 150).Value = OpenFileDialog1.FileName.ToString().Trim

        Comm.ExecuteNonQuery()
        MessageBox.Show("Registro actualizado")
    End Sub

    Private Sub Btnborrar_Click(sender As Object, e As EventArgs) Handles Btnborrar.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = ("Delete from Empleados where Id_Usuario=" + TxtId.Text)
        Try
            Comm.ExecuteNonQuery()
            MessageBox.Show("Registro" + TxtId.Text + "borrado")
        Catch ex As Exception
            MessageBox.Show("Verifique los datos")
        End Try
    End Sub

    Private Sub BtnGaf_Click(sender As Object, e As EventArgs) Handles BtnGaf.Click
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(10, 10, 400, 600))
        e.Graphics.DrawImage(PictureBox1.Image, 90, 30)
        Dim fuente As Font = New Font("Arial", 14, FontStyle.Bold)
        e.Graphics.DrawString("Nombre : " & TxtNombre.Text.Trim() & " " & TxtPaterno.Text.Trim(), fuente, Brushes.Black, New Point(25, 200))
        e.Graphics.DrawString("Categoria" & Cmbcategoria.Text.Trim(), fuente, Brushes.Black, New Point(25, 230))
        e.Graphics.DrawString("Empleado", Fuente, Brushes.Black, New Point(25, 350))
        fuente = New Font("ABC C39 Tall Text", 16, FontStyle.Regular)
        e.Graphics.DrawString("*" & TxtId.Text.Trim() & "*", fuente, Brushes.Black, New Point(150, 400))
    End Sub

    Private Sub TxtRfc_TextChanged(sender As Object, e As EventArgs) Handles TxtRfc.TextChanged

    End Sub
End Class