Imports System.Data
Imports System.Data.SqlClient
Public Class Codigodebarras


    Private Sub Codigodebarras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        config.IniciarConexion()
    End Sub

    Private Sub btnCodigo_Click(sender As Object, e As EventArgs) Handles btnCodigo.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnCodigo_Validated(sender As Object, e As EventArgs) Handles btnCodigo.Validated


    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged

    End Sub

    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnCodigo.Select()
        End If
    End Sub

    Private Sub TxtCodigo_Validated(sender As Object, e As EventArgs) Handles TxtCodigo.Validated
        If TxtCodigo.Text.Trim() = " " Then
            Exit Sub
        End If
        Dim acc As String = " "
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "AccesoUsuario"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@id", SqlDbType.NChar, 10).Value = TxtCodigo.Text.ToString()

        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
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
            Case ""
                Me.Close()
        End Select
    End Sub
End Class