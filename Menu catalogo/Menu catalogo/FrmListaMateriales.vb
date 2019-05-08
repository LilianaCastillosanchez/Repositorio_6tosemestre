Imports System.Data
Imports System.Data.SqlClient

Public Class FrmListaMateriales

    Private Sub FrmListaMateriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        config.IniciarConexion()

        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select Nombre,IdArticulo from Articulos Order by Nombre"
        Dim SqlDa As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDa.Fill(tblArticulos)
        cmbArticuloID.ValueMember = "IdArticulo"
        cmbArticuloID.DisplayMember = "Nombre"
        cmbArticuloID.DataSource = tblArticulos

        Comm.Dispose()

    End Sub

    Private Sub FrmListaMateriales_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ConnSql.Close()
    End Sub

    Public Function ManejodeListadeMateriales(ByVal vProducto As String, ByVal vNombre As String) As DialogResult
        txtNumProducto.Text = vProducto
        txtNombre.Text = vNombre
        Me.Show()
        frmProductos.ActualizaListaMateriales()
        Return btnSalir.DialogResult
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        btnSalir.DialogResult = MessageBoxButtons.YesNo
        Me.Close()

    End Sub

    Private Sub cmbArticuloID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArticuloID.SelectedIndexChanged
        txtNombreArt.Text = cmbArticuloID.SelectedValue.ToString()
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select UnidadMedida from Articulos where IdArticulo='" & cmbArticuloID.SelectedValue.ToString() & "'"
        Dim SqlDR As SqlDataReader
        SqlDR = Comm.ExecuteReader()
        If SqlDR.Read() Then
            txtUnidadMedida.Text = SqlDR("UnidadMedida").ToString()
        End If
        SqlDR.Close()
        Comm.Dispose()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Insert into Lista_Materiales(NumProducto,IdArticulo,UnidadMedida,Cantidad) " _
          & "Values(@NumProducto,@IdArticulo,@UnidadMedida,@Cantidad) "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 20).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = cmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@UnidadMedida", SqlDbType.NVarChar, 10).Value = txtUnidadMedida.Text.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.Decimal, 18, 3).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = CommandType.Text
        Comm.CommandType = "Update Lista_Materiales set Cantidad= @Cantidad where NumProducto=@NumProducto and " _
           & "IdArticulo=@IdArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 20).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = cmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.Decimal, 18, 3).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Delete from  Lista_Materiales where NumProducto=@NumProducto and " _
           & "IdArticulo=@IdArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 20).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = cmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.Decimal, 18, 3).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()

    End Sub
    Private Sub ActualizaLista()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from Lista_Materiales where NumProducto='" & txtNumProducto.Text.ToString _
           & "' Order by IdArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDA.Fill(tblArticulos)
        dvgLista.DataSource = tblArticulos
    End Sub
End Class