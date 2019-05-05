Public Class FrmUnidades
    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click

    End Sub

    Private Sub BtnUdCerrar_Click(sender As Object, e As EventArgs) Handles btnUdCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DGVunidades.DataSource = us.ConsultaUnidades
        ' DGVunidades.Refresh()
    End Sub
End Class