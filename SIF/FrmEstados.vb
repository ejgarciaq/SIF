Public Class FrmEstados
    Dim us As New Logica.Estado
    Private Sub FrmEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVestados.DataSource = us.ConsultaEstados
        DGVestados.Refresh()
    End Sub
End Class