Public Class FrmRoles
    Dim us As New Logica.Roles

    Private Sub FrmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVroles.DataSource = us.ConsultaRoles
        DGVroles.Refresh()
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Try
            If us.IngresarRol(tbID.Text, tbRolDescrip.Text, cbRolEstado.Text) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVroles.DataSource = us.ConsultaRoles
            DGVroles.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btnRolesBorrar_Click(sender As Object, e As EventArgs) Handles btnRolesBorrar.Click

    End Sub

    Private Sub CbRolEstado_CheckedChanged(sender As Object, e As EventArgs) Handles cbRolEstado.CheckedChanged

    End Sub
End Class