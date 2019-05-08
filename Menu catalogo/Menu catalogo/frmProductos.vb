Imports System.Data
Imports System.Data.SqlClient

Public Class frmProductos

    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        config.IniciarConexion()

    End Sub

    Private Sub frmProductos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ConnSql.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMateriales.Click
        If txtNumProducto.Text.ToString().Trim() = "" Then
            MessageBox.Show("PRIMERO INTRODUZCA EL NUMERO DE PRODUCTO", "PIZZAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        FrmListaMateriales.ManejodeListadeMateriales(txtNumProducto.Text.ToString(), txtNombre.Text.ToString())
        ActualizaListaMateriales()

    End Sub
    Public Sub ActualizaListaMateriales()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from Lista_Materiales where NumProducto= '" & txtNumProducto.Text.ToString _
           & "' Order by idArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDA.Fill(tblArticulos)
        dgvArticulos.DataSource = tblArticulos
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "INS_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Double.Parse(txtPrecio.Text.ToString())
        Comm.ExecuteNonQuery()
        LimpiaPantalla()
    End Sub
    Private Sub LimpiaPantalla()
        txtNumProducto.Text = ""
        txtNombre.Text = ""
        txtCosto.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "MODIFICAR_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Double.Parse(txtPrecio.Text.ToString())
        Comm.ExecuteNonQuery()
        LimpiaPantalla()

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()

        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "BORRAR_PRODUCTO"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 10).Value = txtNumProducto.Text.ToString()

        Comm.ExecuteNonQuery()
        LimpiaPantalla()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from Producto where @NumProducto=@NumProducto"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader()
        If Dr.Read() Then
            txtNombre.Text = Dr("Nombre").ToString()
            txtCosto.Text = Dr("Costo").ToString()
            txtPrecio.Text = Dr("Precio").ToString()
        Else
            MessageBox.Show("Regitro No Encontrado", "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            LimpiaPantalla()
        End If
        Dr.Close()
        ActualizaListaMateriales()
    End Sub

    Private Sub btnObtenerCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObtenerCosto.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select dbo.fn_CostoProducto(@NumProducto) as Costo"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader
        If Dr.Read() Then
            txtCosto.Text = Dr("Costo").ToString()
        End If
        Dr.Close()
    End Sub
End Class