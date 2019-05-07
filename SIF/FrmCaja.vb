Public Class FrmCaja
    Dim us As New Logica.Usuario
    Dim em As New Logica.Local
    Dim cl As New Logica.Cliente
    Dim pr As New Logica.Producto
    Dim fc As New Logica.Factura
    Dim de As New Logica.Detalle
    Dim i As Integer = 0

    Private Sub FrmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbUsuario.DataSource = us.ConsultaUsuarios
        cbUsuario.ValueMember = "USU_IDPERSONA"
        cbUsuario.DisplayMember = "USU_IDPERSONA"

        cbLocal.DataSource = em.ConsultaLocales
        cbLocal.ValueMember = "EMP_IDEMPRESA"
        cbLocal.DisplayMember = "EMP_IDEMPRESA"

        cbCliente.DataSource = cl.ConsultaClientes
        cbCliente.ValueMember = "CLI_IDPERSONA"
        cbCliente.DisplayMember = "CLI_IDPERSONA"

        lbProducto.DataSource = pr.ConsultaProductos
        lbProducto.DisplayMember = "PRO_NOMBRE"
        lbProducto.ValueMember = "PRO_IDPRODUCTO"

        VerificarDatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub lbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProducto.SelectedIndexChanged
        If lbProducto.SelectedItem IsNot Nothing Then
            If TypeOf lbProducto.SelectedValue Is DataRowView Then
                Return
            End If
            Dim dt As DataTable = pr.ConsultaProducto(lbProducto.SelectedValue)
            nUD.Maximum = dt.Rows(0).Item(5)
        End If
    End Sub

    Function VerificarDatos()
        If tbFactura.Text = "" Then
            ErrDatos.SetError(tbFactura, "Digite el id de Factura")
            Return False
        Else
            ErrDatos.SetError(tbFactura, "")
        End If
        If cbLocal.Text = "" Then
            ErrDatos.SetError(cbLocal, "No hay locales disponibles")
            Return False
        Else
            ErrDatos.SetError(cbLocal, "")
        End If
        If cbCliente.Text = "" Then
            ErrDatos.SetError(cbCliente, "No hay clientes disponibles")
            Return False
        Else
            ErrDatos.SetError(cbCliente, "")
        End If
        If cbUsuario.Text = "" Then
            ErrDatos.SetError(cbUsuario, "No hay Usuarios disponibles")
            Return False
        Else
            ErrDatos.SetError(cbUsuario, "")
        End If
        If lbProducto.ValueMember Is Nothing Then
            ErrDatos.SetError(lbProducto, "No hay productos disponibles")
            Return False
        Else
            ErrDatos.SetError(lbProducto, "")
        End If
        If nUD.Value = 0 Then
            ErrDatos.SetError(nUD, "Digite la cantidad del producto")
            Return False
        Else
            ErrDatos.SetError(nUD, "")
        End If
        Return True
    End Function

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If VerificarDatos() Then
            If tbFactura.Enabled Then
                If Not fc.VerificarFactura(tbFactura.Text) Then
                    fc.IngresarFactura(tbFactura.Text, cbLocal.SelectedValue, cbCliente.SelectedValue, cbUsuario.SelectedValue, tbFecha.Text)
                    DesActElementos()
                    IngresarProducto()
                    Button3.Enabled = True
                Else
                    ErrDatos.SetError(tbFactura, "Factura ya existente.")
                End If
            Else
                IngresarProducto()
            End If
        Else
            MsgBox("No se puede agregar producto.")
        End If
    End Sub

    Private Sub tbFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbFactura.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            ErrDatos.SetError(tbFactura, "Solo se aceptan números")
            e.Handled = True
        Else
            ErrDatos.SetError(tbFactura, "")
        End If
    End Sub

    Private Sub cbLocal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbLocal.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCliente.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbUsuario.KeyPress
        e.Handled = True
    End Sub

    Private Sub nUD_ValueChanged(sender As Object, e As EventArgs) Handles nUD.ValueChanged
        If nUD.Value = 0 Then
            ErrDatos.SetError(nUD, "Digite la cantidad del producto")
        Else
            ErrDatos.SetError(nUD, "")
        End If
    End Sub

    Sub DesActElementos()
        If tbFactura.Enabled Then
            tbFactura.Enabled = False
            cbLocal.Enabled = False
            cbCliente.Enabled = False
            cbUsuario.Enabled = False
            tbFecha.Enabled = False
        Else
            tbFactura.Enabled = True
            cbLocal.Enabled = True
            cbCliente.Enabled = True
            cbUsuario.Enabled = True
            tbFecha.Enabled = True
        End If
    End Sub

    Sub IngresarProducto()
        Try
            Dim dt As DataTable = pr.ConsultaProducto(lbProducto.SelectedValue)
            Dim id As String = dt.Rows(0).Item(0)
            Dim precio = dt.Rows(0).Item(6) * nUD.Value
            Dim cantidad = dt.Rows(0).Item(5) - nUD.Value
            de.IngresarDetalle(i, tbFactura.Text, id, nUD.Value, precio)
            Dim dt2 As DataTable = fc.ConsultaFactura(tbFactura.Text)
            precio = dt2.Rows(0).Item(5) + precio
            fc.ModificarPrecio(tbFactura.Text, precio)
            pr.ModificarCantidad(id, cantidad)
            i = i + 1
            btnFinalizar.Enabled = True
            Button3.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        DesActElementos()
        i = 0
        btnFinalizar.Enabled = False
        Button3.Enabled = True
    End Sub

End Class