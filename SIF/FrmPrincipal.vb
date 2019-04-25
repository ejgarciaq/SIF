Public Class FrmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim Usuarios As FrmUsuarios
        Usuarios = New FrmUsuarios()
        Usuarios.MdiParent = Me
        Usuarios.Show()
    End Sub
End Class