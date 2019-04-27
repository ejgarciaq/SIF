Public Class login
    Dim us As New Logica.Usuario
    Dim principal As New FrmPrincipal
    Dim admin As Boolean

    Private Sub BTIngresar_Click(sender As Object, e As EventArgs) Handles BTIngresar.Click
        Dim Rsdatos As New DataSet
        If Trim(TBusuario.Text) = "" Or Trim(TBclave.Text) = "" Then
            MsgBox("Por favor ingrese sus datos de acceso!", vbExclamation, "Campos vacíos encontrados")
        Else
            Dim rol As Int16
            If True Then
                TBclave.UseSystemPasswordChar = False
            End If
            rol = us.VerificarUsuario(TBusuario.Text, TBclave.Text)
            TBclave.UseSystemPasswordChar = True
            If (rol = 1) Then
                admin = True
                principal.isAdmin(admin)
                principal.Show()
                Me.Hide()
            ElseIf (rol = 2) Then
                admin = False
                principal.isAdmin(admin)
                principal.Show()
                Me.Hide()
            Else
                MsgBox("acceso fallido! No Registrado", vbCritical, "inicio de sesión fallido")
                TBusuario.Clear()
                TBclave.Clear()
            End If
        End If

    End Sub

    Private Sub CB1_CheckedChanged(sender As Object, e As EventArgs) Handles CB1.CheckedChanged
        If TBclave.UseSystemPasswordChar Then
            TBclave.UseSystemPasswordChar = False
        Else
            TBclave.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Me.Close()
    End Sub

    Function obtenerAdmin()
        Return admin
    End Function
End Class
