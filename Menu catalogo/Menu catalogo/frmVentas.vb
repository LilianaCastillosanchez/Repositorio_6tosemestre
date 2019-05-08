Imports System.Data
Imports System.Data.SqlClient

Public Class frmVentas

    Public TblDetalleVenta As DataTable
    Public vTotalVenta As Double

    Private Sub frmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GeneraTabladeVenta()
        config.IniciarConexion()

    End Sub



    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub BuscarProductos()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "select * from Productos where Nombre like @Nombre"
        ' siguiente renglon
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = TxtProducto.Text.ToString() & "%"
        Dim Da As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblProductos As DataTable = New DataTable()
        Da.Fill(tblProductos)
        dgvProductos.DataSource = tblProductos
        Da.Dispose()
        Comm.Dispose()
    End Sub

    Private Sub TxtProducto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProducto.KeyUp
        If TxtProducto.Text.ToString().Trim() <> "" Then BuscarProductos()
    End Sub

    Private Sub dgvProductos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.DoubleClick
        txtNumProducto.Text = dgvProductos.SelectedRows(0).Cells("Numproducto").Value.ToString()
        txtNombreProducto.Text = dgvProductos.SelectedRows(0).Cells("Nombre").Value.ToString()
        txtPrecio.Text = dgvProductos.SelectedRows(0).Cells("Precio").Value.ToString()
        'xtTipoProd.Text = dgvProductos.SelectedRows(0).Cells("TipoProducto").Value.ToString()
        TxtProducto.Text = " "
        txtCantidad.Focus()
    End Sub



    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim vRes As Integer
            If Integer.TryParse(txtCantidad.Text.ToString(), vRes) = True Then
                If txtNumProducto.Text.ToString().Trim() <> "" Then
                    AgregaNuevoRenglon()
                End If
                TxtProducto.Focus()
            End If
        End If
    End Sub

    Private Sub BtnVentaNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentaNueva.Click
        gbDetalles.Enabled = True
        VentaNueva()
    End Sub
    Private Sub AgregaNuevoRenglon()
        Dim MyDataRow As DataRow
        MyDataRow = TblDetalleVenta.NewRow()
        MyDataRow("NumProducto") = txtNumProducto.Text.ToString()
        MyDataRow("Descripcion") = txtNombreProducto.Text.ToString()
        MyDataRow("Cantidad") = Double.Parse(txtCantidad.Text.ToString())
        MyDataRow("Precio") = Double.Parse(txtPrecio.Text.ToString())
        MyDataRow("TipoProducto") = txtTipoProd.Text.ToString()

        Dim vSubtotal As Double = Double.Parse(txtCantidad.Text.ToString()) * Double.Parse(txtPrecio.Text.ToString())
        MyDataRow("Total") = vSubtotal
        vTotalVenta = vTotalVenta + vSubtotal
        TblDetalleVenta.Rows.Add(MyDataRow)
        TblDetalleVenta.AcceptChanges()

        mskTxtTotal.Text = vTotalVenta
        dgvVentaDetalles.DataSource = TblDetalleVenta.DefaultView
        dgvVentaDetalles.Columns(5).Visible = False
    End Sub
    Private Sub VentaNueva()
        vTotalVenta = 0
        TblDetalleVenta.Clear()

        TxtVentaID.Text = GetVentaId()
        TxtProducto.Text = ""
        dgvProductos.DataSource = Nothing
        dgvVentaDetalles.DataSource = Nothing

        txtNombreProducto.Text = ""
        txtNumProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        mskTxtTotal.Text = "0"

        TxtProducto.Focus()
    End Sub
    Private Function GetVentaId() As String
        Dim vVentaID As String = ""
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select dbo.FN_ObtenerVentaID() as VentaID"
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader
        If Dr.Read() Then
            vVentaID = Dr("VentaID").ToString()
        End If
        Dr.Close()
        Return vVentaID
    End Function

    Private Sub TxtProducto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProducto.Enter
        txtNombreProducto.Text = ""
        txtNumProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
    End Sub
    Private Sub GeneraTabladeVenta()
        TblDetalleVenta = New DataTable()

        Dim MyCol1 As DataColumn = New DataColumn()
        MyCol1.DataType = System.Type.GetType("System.String")
        MyCol1.ColumnName = "NumProducto"
        MyCol1.Caption = "NumProducto"
        MyCol1.Unique = False
        TblDetalleVenta.Columns.Add(MyCol1)

        Dim MyCol2 As DataColumn = New DataColumn()
        MyCol2.DataType = System.Type.GetType("System.String")
        MyCol2.ColumnName = "Descripcion"
        MyCol2.Caption = "Descripcion"
        MyCol2.Unique = False
        TblDetalleVenta.Columns.Add(MyCol2)


        Dim MyCol3 As DataColumn = New DataColumn()
        MyCol3.DataType = System.Type.GetType("System.Decimal")
        MyCol3.ColumnName = "Cantidad"
        MyCol3.Caption = "Cantidad"
        MyCol3.Unique = False
        TblDetalleVenta.Columns.Add(MyCol3)


        Dim MyCol4 As DataColumn = New DataColumn()
        MyCol4.DataType = System.Type.GetType("System.Decimal")
        MyCol4.ColumnName = "Precio"
        MyCol4.Caption = "Precio"
        MyCol4.Unique = False
        TblDetalleVenta.Columns.Add(MyCol4)

        Dim MyCol5 As DataColumn = New DataColumn()
        MyCol5.DataType = System.Type.GetType("System.Decimal")
        MyCol5.ColumnName = "Total"
        MyCol5.Caption = "Total"
        MyCol5.Unique = False
        TblDetalleVenta.Columns.Add(MyCol5)

        Dim MyCol6 As DataColumn = New DataColumn()
        MyCol6.DataType = System.Type.GetType("System.String")
        MyCol6.ColumnName = "TipoProducto"
        MyCol6.Caption = "TipoProducto"
        MyCol6.Unique = False
        TblDetalleVenta.Columns.Add(MyCol6)
    End Sub

    Private Sub btnParaLlevar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParaLlevar.Click
        If dgvVentaDetalles.RowCount > 0 Then
            If GrabaVenta("") Then
                MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
                VentaNueva()
            End If
        End If

    End Sub

    Private Sub btnLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocal.Click
        If dgvVentaDetalles.RowCount > 0 Then
            If GrabaVenta("") Then
                MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
                VentaNueva()
            End If
        End If

    End Sub

    Private Sub btntel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntel.Click
        If dgvVentaDetalles.RowCount > 0 Then
            'Buscar el Cliente
            If GrabaVenta("") Then
                MessageBox.Show("IMPRIMIENDO TICKET", "PIZZAS", MessageBoxButtons.OK)
                VentaNueva()
            End If
        End If

    End Sub
    Public Function GrabaVenta(ByVal vClienteId As String) As Boolean
        Dim vGraba As Boolean = False
        Dim Comm As SqlCommand = New SqlCommand()
        Try
            Comm.Connection = ConnSql
            Comm.CommandType = CommandType.StoredProcedure
            Comm.CommandText = "INS_VENTA"
            Comm.Parameters.Add("@VentaID", SqlDbType.NVarChar, 15).Value = TxtVentaID.Text.ToString().Trim()
            Comm.Parameters.Add("@IdUsuario", SqlDbType.NChar, 10).Value = ConnSql.ConnectionString.ToString()
            Comm.Parameters.Add("@ClienteId", SqlDbType.NVarChar, 10).Value = vClienteId.ToString().Trim()
            Comm.ExecuteNonQuery()
        Catch sqlEx As SqlException
            MessageBox.Show("Ocurrio un Error " & sqlEx.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error " & ex.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        End Try

        Dim CommDet As SqlCommand = New SqlCommand()
        Dim IRow As Integer
        Try
            CommDet.Connection = ConnSql
            CommDet.CommandType = CommandType.StoredProcedure
            For IRow = 0 To dgvVentaDetalles.RowCount - 1
                CommDet.CommandText = "INS_DETALLEVENTA"
                CommDet.Parameters.Clear()
                CommDet.Parameters.Add("@VentaID", SqlDbType.VarChar, 15).Value = TxtVentaID.Text.ToString().Trim()
                CommDet.Parameters.Add("@Producto", SqlDbType.VarChar, 15).Value = dgvVentaDetalles.Rows(IRow).Cells("NumProducto").Value.ToString()
                CommDet.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Decimal.Parse(dgvVentaDetalles.Rows(IRow).Cells("Precio").Value.ToString())
                CommDet.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = Decimal.Parse(dgvVentaDetalles.Rows(IRow).Cells("Cantidad").Value.ToString())
                CommDet.Parameters.Add("@TipoProd", SqlDbType.VarChar, 15).Value = dgvVentaDetalles.Rows(IRow).Cells("TipoProducto").Value.ToString()
                CommDet.ExecuteNonQuery()
            Next
        Catch sqlEx As SqlException
            MessageBox.Show("Ocurrio un Error " & sqlEx.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error " & ex.Message.ToString(), "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return vGraba
        End Try
        vGraba = True
        Return vGraba
    End Function

    Private Sub frmVentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ConnSql.Close()
    End Sub

    Private Sub TxtProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtProducto.TextChanged

    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub
End Class