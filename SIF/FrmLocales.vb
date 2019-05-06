Public Class FrmLocales
    Dim lo As New Logica.Local

    Private Sub BtnLocalCerrar_Click(sender As Object, e As EventArgs) Handles btnLocalCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmLocales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVlocales.DataSource = lo.ConsultaLocales
        DGVlocales.Refresh()
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Try
            If lo.IngresarLocal(tbId.Text, tbNombre.Text) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVlocales.DataSource = lo.ConsultaLocales
            DGVlocales.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class