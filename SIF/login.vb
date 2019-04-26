Public Class login
    Dim us As New Logica.Usuario

    Private Sub BTIngresar_Click(sender As Object, e As EventArgs) Handles BTIngresar.Click
        Dim Rsdatos As New DataSet
        If Trim(TBusuario.Text) = "" Or Trim(TBclave.Text) = "" Then
            MsgBox("Por favor ingrese sus datos de acceso!", vbExclamation, "Campos vacíos encontrados")
        Else
            If us.VerificarUsuario(TBusuario.Text, TBclave.Text) Then
                MsgBox("Acceso satisfactorio", vbInformation, "inicio de sesión exitoso")
                FrmPrincipal.Show()
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

    Private Sub TBclave_TextChanged(sender As Object, e As EventArgs) Handles TBclave.TextChanged

    End Sub

End Class
