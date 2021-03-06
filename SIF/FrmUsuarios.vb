﻿Imports System.Data
Imports System.Data.OleDb

Public Class FrmUsuarios
    Dim us As New Logica.Usuario
    Dim ro As New Logica.Roles

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVusuarios.DataSource = us.ConsultaUsuarios
        DGVusuarios.Refresh()

        cbRol.DataSource = ro.ConsultaRoles
        cbRol.DisplayMember = "ROL_DESCRIPCION"
        cbRol.ValueMember = "ROL_IDROL"
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click

        Dim isValid As Boolean = us.IsPasswordValid(tbPassword.Text)
        If (Not (isValid)) Then
            If Not tbPassword.Text = tbPasswordConf.Text Then
                tbPassword.Clear()
                tbPasswordConf.Clear()
                MessageBox.Show("Contraseña no permitida.")
                Return
            End If
        End If
        Try
            If us.IngresarUsuario(tbID.Text, tbNombre.Text, tbApellido1.Text, tbApellido2.Text, tbUserName.Text, tbPassword.Text, cbRol.SelectedValue) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVusuarios.DataSource = us.ConsultaUsuarios
            DGVusuarios.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUserCerrar_Click(sender As Object, e As EventArgs) Handles btnUserCerrar.Click
        Me.Close()
    End Sub
End Class