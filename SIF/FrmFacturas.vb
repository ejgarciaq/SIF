Public Class FrmFacturas
    Dim fc As New Logica.Factura
    Dim de As New Logica.Detalle

    Private Sub BtnFactCerrar_Click(sender As Object, e As EventArgs) Handles btnFactCerrar.Click
        Me.Close()
    End Sub

    Private Sub DGVfacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVfacturas.CellContentClick
        DGVdetalle.DataSource = de.ConsultaDetalle(DGVfacturas.CurrentCell.Value.ToString)
    End Sub

    Private Sub DGVfacturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVfacturas.CellContentClick
        DGVfacturas.DataSource = fc.ConsultaFacturas
    End Sub

    Private Sub FrmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVfacturas.DataSource = fc.ConsultaFacturas
    End Sub
End Class