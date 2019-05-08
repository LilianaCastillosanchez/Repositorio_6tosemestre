Imports System.Data
Imports System.Data.SqlClient
Public Class Inicio



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAceptar.Click, MyBase.Click
        If txtusuario.Text.Trim() = " " Then
            Exit Sub
        End If
        Dim acc As String = " "
        Dim pass As String
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "AccesoUsuarioLogin"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 25).Value = txtusuario.Text.ToString()


        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
                pass = DReader("Password")
            End While
        Else
            MessageBox.Show("Usuario no encontrado")
        End If
        DReader.Close()

        Select Case acc.Trim()
            Case "Administrador"
                Catalogo.Show()
            Case "Cajero"
                frmVentas.Show()
        End Select

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        config.IniciarConexion()

    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Inicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ConnSql.Close()
    End Sub
End Class
