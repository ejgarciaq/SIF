Imports MySql.Data.MySqlClient


Public Class login
    Private Sub BTIngresar_Click(sender As Object, e As EventArgs) Handles BTIngresar.Click
        Dim Rsdatos As New DataSet
        If Trim(TBusuario.Text) = "" Or Trim(TBclave.Text) = "" Then
            MsgBox("Por favor ingrese sus datos de acceso!", vbExclamation, "Campos vacíos encontrados")
        Else
            CerraConexion()
            Conectar()
            Dim mysql = "SELECT * FROM usuarios_table WHERE USR_NOMBRE = '" & TBusuario.Text & "' AND USR_PASSWORD = '" & TBclave.Text & "'"
            cmd = New MySqlCommand(mysql, cnn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            Try
                If dr.Read = False Then
                    MsgBox("acceso fallido! No Registrado", vbCritical, "inicio de sesión fallido")
                    TBusuario.Clear()
                    TBclave.Clear()
                Else
                    MsgBox("Acceso satisfactorio", vbInformation, "inicio de sesión exitoso")
                    FrmPrincipal.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub CB1_CheckedChanged(sender As Object, e As EventArgs) Handles CB1.CheckedChanged
        If TBclave.UseSystemPasswordChar = False Then
            TBclave.UseSystemPasswordChar = True
        Else
            TBclave.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Me.Close()
    End Sub

    Private Sub TBclave_TextChanged(sender As Object, e As EventArgs) Handles TBclave.TextChanged

    End Sub



End Class
