Public Class FrmFormaPag
    Dim fp As New Logica.FormaPago
    Private Sub BtnFormPagCerrar_Click(sender As Object, e As EventArgs) Handles btnFormPagCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmFormaPag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVformapagos.DataSource = fp.ConsultaFormaPagos
        DGVformapagos.Refresh()
    End Sub

    Private Sub btnFormPagGuardar_Click(sender As Object, e As EventArgs) Handles btnFormPagGuardar.Click
        Try
            If fp.IngresarFormaPago(tbId.Text, tbDescripcion.Text) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVformapagos.DataSource = fp.ConsultaFormaPagos
            DGVformapagos.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class