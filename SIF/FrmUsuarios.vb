Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.OleDb


Public Class FrmUsuarios

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CerraConexion()
        Conectar()
        Dim consulta As String
        consulta = "SELECT *  FROM usuarios_table"
        adaptador = New MySql.Data.MySqlClient.MySqlDataAdapter(consulta, cnn)
        datos = New DataSet
        adaptador.Fill(datos, "usuarios_table")
        DGVusuarios.DataSource = datos
        DGVusuarios.DataMember = "usuarios_table"
        DGVusuarios.Refresh()
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Dim cmd As New MySqlCommand
        Dim r As Integer
        Dim cambio As Byte = CBuserEstado.Text
        Dim isValid As Boolean = IsPasswordValid(TBuserPass.Text)
        If (Not (isValid)) Then
            If TBuserPass.Text = TBuserPassConf.Text Then
                TBuserPass.Clear()
                TBuserPassConf.Clear()
                MessageBox.Show("Contraseña no permitida.")

                Return
            End If
        End If
            Try

            cmd = New MySqlCommand("INSERT INTO usuarios_table VALUES ('" & TBuserID.Text & "','" & CBuserRol.Text & "','" & TBuserName.Text & "','" & TBuserIntentos.Text & "','" & TBuserPass.Text & "','" & cambio & "')", cnn)
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Registrado correctamente")
            End If


            Dim consulta As String
            consulta = "SELECT *  FROM usuarios_table"
            adaptador = New MySql.Data.MySqlClient.MySqlDataAdapter(consulta, cnn)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios_table")
            DGVusuarios.DataSource = datos
            DGVusuarios.DataMember = "usuarios_table"
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