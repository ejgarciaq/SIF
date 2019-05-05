Public Class FrmFormaPag
    Dim us As New Logica.FormaPago
    Private Sub BtnFormPagCerrar_Click(sender As Object, e As EventArgs) Handles btnFormPagCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmFormaPag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVformPago.DataSource = us.ConsultaFormaPago
        DGVformPago.Refresh()
    End Sub
End Class