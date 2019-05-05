Public Class FrmLocales
    Dim us As New Logica.Empresa
    Private Sub BtnLocalCerrar_Click(sender As Object, e As EventArgs) Handles btnLocalCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmLocales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVlocales.DataSource = us.ConsultaLocal
        DGVlocales.Refresh()
    End Sub
End Class