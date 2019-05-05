Public Class FrmFacturas
    Dim us As New Logica.Factura
    Private Sub BtnFactCerrar_Click(sender As Object, e As EventArgs) Handles btnFactCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVfacturas.DataSource = us.ConsultaFacturas
        DGVfacturas.Refresh()
    End Sub
End Class