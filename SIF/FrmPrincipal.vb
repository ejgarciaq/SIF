Public Class FrmPrincipal
    Dim Usuarios As New FrmUsuarios
    Dim Clientes As New FrmClientes
    Dim Empresas As New FrmEmpresas
    Dim Productos As New FrmProductos
    Dim Facturas As New FrmFacturas
    Dim Caja As New FrmCaja
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If Usuarios.Visible Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Usuarios = New FrmUsuarios
            Usuarios.MdiParent = Me
            Usuarios.Show()
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        If Clientes.Visible Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Clientes = New FrmClientes
            Clientes.MdiParent = Me
            Clientes.Show()
        End If
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        If Empresas.Visible Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Empresas = New FrmEmpresas
            Empresas.MdiParent = Me
            Empresas.Show()
        End If
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        If Productos.Visible Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Productos = New FrmProductos
            Productos.MdiParent = Me
            Productos.Show()
        End If
    End Sub

    Private Sub CajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajaToolStripMenuItem.Click
        If Caja.Visible Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Caja = New FrmCaja
            Caja.MdiParent = Me
            Caja.Show()
        End If
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        If Facturas.Visible = True Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Facturas = New FrmFacturas
            Facturas.MdiParent = Me
            Facturas.Show()
        End If
    End Sub

End Class