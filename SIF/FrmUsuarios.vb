Imports System.Data
Imports System.Data.OleDb

Public Class FrmUsuarios
    Dim us As New Logica.Usuario

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVusuarios.DataSource = us.ConsultaUsuario
        DGVusuarios.Refresh()
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Dim cambio As Boolean = cbEstado.Checked
        'Dim isValid As Boolean = us.IsPasswordValid(TBuserPass.Text)
        'If (Not (isValid)) Then
        'If TBuserPass.Text = TBuserPassConf.Text Then
        'TBuserPass.Clear()
        'TBuserPassConf.Clear()
        'MessageBox.Show("Contraseña no permitida.")
        'Return
        'End If
        'End If
        Try
            If us.IngresarUsuario(TBuserID.Text, CBuserRol.Text, TBuserName.Text, TBuserIntentos.Text, TBuserPass.Text, cambio) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVusuarios.DataSource = us.ConsultaUsuario
            DGVusuarios.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'CerraConexion()
        'TBuserID.Clear()
        'TBuserName.Clear()
        'TBuserIntentos.Clear()
        'TBuserPass.Clear()
        'TBuserPassConf.Clear()
        'CBuserRol.Text = ""
        'CBuserEstado.Text = ""
    End Sub

    Private Sub TBuserPass_TextChanged(sender As Object, e As EventArgs) Handles TBuserPass.TextChanged

    End Sub

End Class