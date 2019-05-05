Public Class FrmProductos
    Dim us As New Logica.Producto
    Private Sub BtnProdCerrar_Click(sender As Object, e As EventArgs) Handles btnProdCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVprodutos.DataSource = us.ConsultaProductoCompleta
        DGVprodutos.Refresh()
    End Sub
End Class