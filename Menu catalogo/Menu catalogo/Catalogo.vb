
Public Class Catalogo
    Private Sub btnInicio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        Empleados.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        config.IniciarConexion()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click

    End Sub

    Private Sub ListaDeMaterialesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ListaDeMaterialesToolStripMenuItem.Click
        FrmListaMateriales.Show()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        Catalogo_Articulos.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductos.Show()
    End Sub

    Private Sub PromocionesYCombosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesYCombosToolStripMenuItem.Click
        frmPromComb.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Catalogo_Articulos.Show()
        Empleados.MdiParent = Me
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class