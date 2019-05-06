Public Class FrmCategorias
    Dim ca As New Logica.Categoria

    Private Sub FrmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVcategorias.DataSource = ca.ConsultaCategorias
        DGVcategorias.Refresh()
    End Sub

    Private Sub btnCatGuardar_Click(sender As Object, e As EventArgs) Handles btnCatGuardar.Click
        Try
            If ca.IngresarCategoria(tbId.Text, tbDescripcion.Text) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVcategorias.DataSource = ca.ConsultaCategorias
            DGVcategorias.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class