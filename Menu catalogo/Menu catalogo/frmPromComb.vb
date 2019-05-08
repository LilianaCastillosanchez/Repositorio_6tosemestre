Imports System.Data
Imports System.Data.SqlClient

Public Class frmPromComb

    Private Sub frmPromComb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        config.IniciarConexion()
        LlenaProductos()
        LlenaCombosLista()


    End Sub

    Private Sub Btnpasar_Click(sender As Object, e As EventArgs) Handles Btnpasar.Click
        lstProductos.Items.Add(cmbproducto.Text.ToString())
    End Sub

    Private Sub frmPromComb_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ConnSql.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "INS_COMBOS"
        Comm.Parameters.Add("@NombreCombo", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Tipo", SqlDbType.NVarChar, 50).Value = cmbTipo.Text.ToString()
        Comm.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = dtpFechaInicio.Value
        Comm.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = dtpFechaFin.Value
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal, 18, 2).Value = Double.Parse(txtPreciofinal.Text.ToString())
        Comm.ExecuteNonQuery()

        Dim Sql As String
        Dim ICount As Integer
        Dim vProdID As String = ""
        Dim vTipoProducto As String = ""
        For ICount = 0 To lstProductos.Items.Count - 1
            Sql = "Select * from Productos where Nombre = '" & lstProductos.Items(ICount).ToString() & "'"
            Dim CommD As SqlCommand = New SqlCommand(Sql, ConnSql)
            Dim SqlDr As SqlDataReader = CommD.ExecuteReader()
            If SqlDr.Read() Then
                vProdID = SqlDr("NumProducto").ToString()
                vTipoProducto = SqlDr("TipoProducto").ToString()
            End If
            SqlDr.Close()
            Dim CommIns As SqlCommand = New SqlCommand()
            CommIns.CommandType = CommandType.StoredProcedure
            CommIns.Connection = ConnSql
            CommIns.CommandText = "INS_CombosyOfertasDetalles"
            CommIns.Parameters.Add("@NombreCombo", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
            CommIns.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = vProdID.ToString()
            CommIns.Parameters.Add("@TipoProducto", SqlDbType.VarChar, 15).Value = vTipoProducto.ToString()
            CommIns.ExecuteNonQuery()
            CommIns.Dispose()

        Next
        lstProductos.Items.Clear()
        txtNombre.Text = ""
        txtPreciofinal.Text = ""

        LlenaCombosLista()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LlenaCombosLista()
        Dim Sql As String = "Select * from CombosyOfertas order by NombreCombo"
        Dim Comm As SqlCommand = New SqlCommand(Sql, ConnSql)
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCombos As DataTable = New DataTable()
        Da.Fill(tblCombos)
        dvgCombos.DataSource = tblCombos.DefaultView
    End Sub
    Private Sub LlenaProductos()
        Dim Sql As String = "Select * from Productos order by Nombre"
        Dim Comm As SqlCommand = New SqlCommand(Sql, ConnSql)
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblProductos As DataTable = New DataTable()
        Da.Fill(tblProductos)
        cmbproducto.ValueMember = "NumProducto"
        cmbproducto.DisplayMember = "Nombre"
        cmbproducto.DataSource = tblProductos
    End Sub

    Private Sub cmbproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproducto.SelectedIndexChanged
        Dim Sql As String = "Select Precio from Productos where Numproducto = '" _
           & cmbproducto.SelectedValue.ToString() & "'"
        Dim Comm As SqlCommand = New SqlCommand(Sql, ConnSql)
        Dim SqlDr As SqlDataReader = Comm.ExecuteReader()
        If SqlDr.Read() Then
            txtPrecioNormal.Text = SqlDr("Precio").ToString()
        End If
        SqlDr.Close()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand

        Dim vNombreCombo As String
        If dvgCombos.SelectedRows.Count > 0 Then
            vNombreCombo = dvgCombos.SelectedRows(0).Cells("NombreCombo").Value.ToString()
            Comm = New SqlCommand()
            Comm.Connection = ConnSql
            Comm.CommandType = CommandType.StoredProcedure
            Comm.CommandText = "BORRAR_COMBOS"
            Comm.Parameters.Add("@NombreCombo", SqlDbType.VarChar, 150).Value = vNombreCombo.ToString()
            Comm.ExecuteNonQuery()

            LlenaCombosLista()
        Else
            MessageBox.Show("Seleccione el Renglon a Borrar ", "UAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
