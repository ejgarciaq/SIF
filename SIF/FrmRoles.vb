Public Class FrmRoles
    Dim us As New Logica.Roles

    Private Sub FrmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVroles.DataSource = us.ConsultaRoles
        DGVroles.Refresh()
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click


    End Sub


    Private Sub btnRolesBorrar_Click(sender As Object, e As EventArgs) Handles btnRolesBorrar.Click

    End Sub

    Private Sub BtnRolesCerrar_Click(sender As Object, e As EventArgs) Handles btnRolesCerrar.Click
        Me.Close()
    End Sub
End Class