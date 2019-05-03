﻿Public Class FrmEstados
    Dim us As New Logica.Estado
    Private Sub FrmEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVestados.DataSource = us.ConsultaEstados
        DGVestados.Refresh()
    End Sub


    Private Sub BtnEstguardar_Click(sender As Object, e As EventArgs) Handles btnEstguardar.Click
        Try
            If us.IngresarEstado(tbEstID.Text, tbEstDescrip.Text, cbEstEstado.Checked) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVestados.DataSource = us.ConsultaEstados
            DGVestados.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class