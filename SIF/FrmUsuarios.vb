Public Class FrmUsuarios
    Dim us As New Logica.Usuario
    Dim ro As New Logica.Rol

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVusuarios.DataSource = us.ConsultaUsuarios
        DGVusuarios.Refresh()
        cbRol.DataSource = ro.ConsultaRol
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
            MsgBox(cbRol.SelectedValue)
            If us.IngresarUsuario(tbID.Text, tbNombre.Text, tbApellido1.Text, tbApellido2.Text, tbUserName.Text, tbPassword.Text, cbRol.SelectedValue) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVusuarios.DataSource = us.ConsultaUsuarios
            DGVusuarios.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        If tbNombre.Text = "" Then
            VerCampos.SetError(tbNombre, "El nombre no puede estar vacio.")
        Else
            VerCampos.SetError(tbNombre, "")
        End If
    End Sub

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged
        Dim i As Integer
        If Integer.TryParse(tbID.Text, i) = 0 Then
            VerCampos.SetError(tbID, "El ID debe ser numerico")
            tbID.Text = ""
        Else
            VerCampos.SetError(tbID, "")
        End If
    End Sub

    Private Sub DGVusuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVusuarios.CellContentClick
        Dim dt As DataTable = us.ConsultaUsuario(DGVusuarios.Item(0, e.RowIndex).Value.ToString)
        tbID.Text = dt.Rows(0).Item(0)
        tbNombre.Text = dt.Rows(0).Item(1)
        tbApellido1.Text = dt.Rows(0).Item(2)
        tbApellido2.Text = dt.Rows(0).Item(3)
        tbUserName.Text = dt.Rows(0).Item(4)
        tbPassword.Text = dt.Rows(0).Item(5)
        tbPasswordConf.Text = dt.Rows(0).Item(5)
        cbRol.Text = dt.Rows(0).Item(6)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        us.BorrarUsuario(tbID.Text)
    End Sub
End Class