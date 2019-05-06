Public Class FrmUnidades
    Dim us As New Logica.Unidad
    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Try
            If us.IngresarUnidad(tbUdID.Text, tbUdDescrip.Text, True) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVunidades.DataSource = us.ConsultaUnidad
            DGVunidades.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUdCerrar_Click(sender As Object, e As EventArgs) Handles btnUdCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVunidades.DataSource = us.ConsultaUnidad
        DGVunidades.Refresh()
    End Sub
End Class