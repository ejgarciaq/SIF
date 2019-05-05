Public Class FrmCategorias
    Dim us As New Logica.Categoria
    Private Sub FrmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVcategoria.DataSource = us.ConsultaCategoria
        DGVcategoria.Refresh()
    End Sub

    Private Sub BtnCatCerrar_Click(sender As Object, e As EventArgs) Handles btnCatCerrar.Click
        Me.Close()
    End Sub
End Class