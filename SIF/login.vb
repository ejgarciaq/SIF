﻿Public Class login
    Dim us As New Logica.Usuario
    Dim principal As New FrmPrincipal
    Dim admin As Boolean

    Private Sub BTIngresar_Click(sender As Object, e As EventArgs) Handles BTIngresar.Click
        Dim Rsdatos As New DataSet
        If Trim(TBusuario.Text) = "" Or Trim(TBclave.Text) = "" Then
            MsgBox("Por favor ingrese sus datos de acceso!", vbExclamation, "Campos vacíos encontrados")
        Else
            Dim rol As Int16
            rol = us.VerificarUsuario(TBusuario.Text, TBclave.Text.ToString)
            If (rol = 1) Then
                admin = True
                principal.isAdmin(admin)
                principal.Show()
                TBusuario.Text = ""
                TBclave.Text = ""
                Me.Hide()
            ElseIf (rol = 2) Then
                admin = False
                principal.isAdmin(admin)
                principal.Show()
                TBusuario.Text = ""
                TBclave.Text = ""
                Me.Hide()
            Else
                MsgBox("acceso fallido! No Registrado", vbCritical, "inicio de sesión fallido")
                TBusuario.Clear()
                TBclave.Clear()
                Return
            End If
            'If admin Then
            '    If us.VerificarContrasena(TBusuario.Text, TBclave.Text.ToString) Then
            '        principal.isAdmin(admin)
            '        principal.Show()
            '        TBusuario.Text = ""
            '        TBclave.Text = ""
            '        Me.Hide()
            '    Else
            '        MsgBox("Contraseña incorrecta.")
            '    End If
            'Else
            '    If us.VerificarContrasena(TBusuario.Text, TBclave.Text.ToString) Then
            '        principal.isAdmin(admin)
            '        principal.Show()
            '        TBusuario.Text = ""
            '        TBclave.Text = ""
            '        Me.Hide()
            '    Else
            '        MsgBox("Contraseña incorrecta.")
            '        If Not us.BajarIntentos(TBusuario.Text) Then
            '            MsgBox("Se alcanzo el limite de intentos.")
            '            End
            '        End If
            '    End If
            'End If
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

    Private Sub TBclave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBclave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim Rsdatos As New DataSet
            If Trim(TBusuario.Text) = "" Or Trim(TBclave.Text) = "" Then
                MsgBox("Por favor ingrese sus datos de acceso!", vbExclamation, "Campos vacíos encontrados")
            Else
                Dim rol As Int16
                rol = us.VerificarUsuario(TBusuario.Text, TBclave.Text.ToString)
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
        End If
    End Sub

    Private Sub TBusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBusuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim Rsdatos As New DataSet
            If Trim(TBusuario.Text) = "" Or Trim(TBclave.Text) = "" Then
                MsgBox("Por favor ingrese sus datos de acceso!", vbExclamation, "Campos vacíos encontrados")
            Else
                Dim rol As Int16
                rol = us.VerificarUsuario(TBusuario.Text, TBclave.Text.ToString)
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
        End If
    End Sub
End Class
