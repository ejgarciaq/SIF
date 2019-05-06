Public Class FrmRoles
    Dim ro As New Logica.Roles

    Private Sub FrmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVroles.DataSource = ro.ConsultaRoles
        DGVroles.Refresh()
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Try
            If ro.IngresarRol(tbID.Text, tbDescripcion.Text) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVroles.DataSource = ro.ConsultaRoles
            DGVroles.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRolesCerrar_Click(sender As Object, e As EventArgs) Handles btnRolesCerrar.Click
        Me.Close()
    End Sub

End Class