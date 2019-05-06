Public Class FrmClientes
    Dim cl As New Logica.Cliente
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVclientes.DataSource = cl.ConsultaClientes
        DGVclientes.Refresh()
    End Sub

    Private Sub BtnClienCerrar_Click(sender As Object, e As EventArgs) Handles btnClienCerrar.Click
        Me.Close()
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Try
            If cl.IngresarCliente(tbId.Text, tbNombre.Text, tbApellido1.Text, tbApellido2.Text) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVclientes.DataSource = cl.ConsultaClientes
            DGVclientes.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class