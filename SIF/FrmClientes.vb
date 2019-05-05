Public Class FrmClientes
    Dim us As New Logica.Cliente
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVclientes.DataSource = us.ConsultaClientes
        DGVclientes.Refresh()
    End Sub
End Class