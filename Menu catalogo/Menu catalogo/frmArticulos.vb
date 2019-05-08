Imports System.Data
Imports System.Data.SqlClient

Public Class Catalogo_Articulos
    Dim TblArticulos As DataTable = New DataTable()
    Public vIDArticuloID As String
    Public vRegistroActual As Integer
    Public vTotalArticulos As Integer
    Public vArticuloNuevo As Boolean = False

    Private Sub Catalogo_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        config.IniciarConexion()
        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)

    End Sub

    Private Sub Catalogo_Articulos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ConnSql.Close()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
    Private Sub LlenaTablaArticulos()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from Articulos Order by idArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        SqlDA.Fill(TblArticulos)
        dgvArticulos.DataSource = TblArticulos
        vTotalArticulos = TblArticulos.Rows.Count
        If TblArticulos.Rows.Count = 0 Then
            tsbPrimero.Enabled = False
            tsbAnterior.Enabled = False
            tsbSiguiente.Enabled = False
            tsbUltimo.Enabled = False
        Else
            vIDArticuloID = TblArticulos.Rows(0)("IdArticulo").ToString()
            Llena_Textos(0)
        End If
    End Sub
    Private Sub HabilitaDeshabilitaTextos(ByVal vEdicion As Boolean)
        txtIDArticulo.ReadOnly = Not vEdicion
        txtNombre.ReadOnly = Not vEdicion
        cmbUnidadMedida.Enabled = vEdicion
        ndMinimo.Enabled = vEdicion
        ndMaximo.Enabled = vEdicion
        txtCosto.ReadOnly = Not vEdicion
        cmbVigencia.Enabled = vEdicion
        txtCantidadExistente.ReadOnly = Not vEdicion
        txtPrecioVenta.ReadOnly = Not vEdicion

        If vEdicion = True Then
            tsbGrabar.Enabled = True
            tsbCancelar.Enabled = True
            tsbNuevo.Enabled = False
            tsbEditar.Enabled = False
            tsbBorrar.Enabled = False

            tsbPrimero.Enabled = False
            tsbAnterior.Enabled = False
            tsbSiguiente.Enabled = False
            tsbUltimo.Enabled = False

        Else
            vArticuloNuevo = False
            tsbGrabar.Enabled = False
            tsbCancelar.Enabled = False
            tsbNuevo.Enabled = True
            tsbEditar.Enabled = True
            tsbBorrar.Enabled = True

            tsbPrimero.Enabled = True
            tsbAnterior.Enabled = True
            tsbSiguiente.Enabled = True
            tsbUltimo.Enabled = True
        End If
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        HabilitaDeshabilitaTextos(True)
        vArticuloNuevo = True
        TabControl1.SelectedIndex = 1

        txtIDArticulo.Text = ""
        txtNombre.Text = ""
        cmbUnidadMedida.Text = ""
        ndMinimo.Value = 1
        ndMaximo.Value = 1
        txtCosto.Text = ""
        cmbVigencia.Text = ""
        txtCantidadExistente.Text = 1
        txtPrecioVenta.Text = 0
        txtIDArticulo.Focus()

    End Sub

    Private Sub Llena_Textos(ByVal vRecord As Integer)
        txtIDArticulo.Text = TblArticulos.Rows(vRecord)("IdArticulo").ToString()
        txtNombre.Text = TblArticulos.Rows(vRecord)("Nombre").ToString()
        cmbUnidadMedida.Text = TblArticulos.Rows(vRecord)("UnidadMedida").ToString()
        ndMinimo.Value = Decimal.Parse(TblArticulos.Rows(vRecord)("Minimo").ToString())
        ndMaximo.Value = Decimal.Parse(TblArticulos.Rows(vRecord)("Maximo").ToString())
        txtCosto.Text = TblArticulos.Rows(vRecord)("Costo").ToString()
        cmbVigencia.Text = TblArticulos.Rows(vRecord)("Vigencia").ToString()
        txtCantidadExistente.Text = TblArticulos.Rows(vRecord)("CantidadExistente").ToString()
        txtPrecioVenta.Text = TblArticulos.Rows(vRecord)("PrecioVenta").ToString()
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        HabilitaDeshabilitaTextos(False)
    End Sub

    Private Sub tsbPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrimero.Click
        Llena_Textos(0)
    End Sub

    Private Sub tsbAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnterior.Click
        If vRegistroActual > 0 Then
            vRegistroActual = vRegistroActual - 1
            Llena_Textos(vRegistroActual)
        End If
    End Sub

    Private Sub tsbSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSiguiente.Click
        If (vRegistroActual + 1) < vTotalArticulos Then
            vRegistroActual = vRegistroActual + 1
            Llena_Textos(vRegistroActual)
        End If
    End Sub

    Private Sub tsbUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUltimo.Click
        Llena_Textos(vTotalArticulos - 1)
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Dim vStoreProcedure As String
        If vArticuloNuevo = True Then
            vStoreProcedure = "INS_ARTICULO"
        Else
            vStoreProcedure = "MODIFICA_ARTICULO"
        End If
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = vStoreProcedure
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = txtIDArticulo.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@UnidadMedida", SqlDbType.NVarChar, 10).Value = cmbUnidadMedida.Text.ToString()
        Comm.Parameters.Add("@Min", SqlDbType.Decimal, 18, 0).Value = ndMinimo.Value
        Comm.Parameters.Add("@Max", SqlDbType.Decimal, 18, 0).Value = ndMaximo.Value
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal, 18, 0).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@CantidadExixtente", SqlDbType.Decimal, 18, 3).Value = Double.Parse(txtCantidadExistente.Text.ToString())
        Comm.Parameters.Add("@Vigencia", SqlDbType.NChar, 10).Value = cmbVigencia.Text.ToString()
        Comm.Parameters.Add("@PrecioVenta", SqlDbType.Decimal, 18, 0).Value = Double.Parse(txtPrecioVenta.Text.ToString())
        Comm.ExecuteNonQuery()

        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)
    End Sub

    Private Sub dgvArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellContentClick
        Llena_Textos(e.RowIndex)
    End Sub

    Private Sub tsbBorrar_Click(sender As Object, e As EventArgs) Handles tsbBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "BORRAR_ARTICULO"
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = txtIDArticulo.Text.ToString()
        Comm.ExecuteNonQuery()

        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)
    End Sub
End Class