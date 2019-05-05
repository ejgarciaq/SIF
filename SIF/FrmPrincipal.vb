Public Class FrmPrincipal
    Dim Usuarios As New FrmUsuarios
    Dim Clientes As New FrmClientes
    Dim Empresas As New FrmLocales
    Dim Productos As New FrmProductos
    Dim Facturas As New FrmFacturas
    Dim Caja As New FrmCaja
    Dim Roles As New FrmRoles
    Dim Unidades As New FrmUnidades
    Dim Estados As New FrmEstados
    Dim Categorias As New FrmCategorias
    Dim FormasPago As New FrmFormaPag

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
            Empresas = New FrmLocales
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

    Sub isAdmin(i As Boolean)
        If i Then
            tsConfiguracion.Visible = True
        Else
            tsConfiguracion.Visible = False
        End If
    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click
        If Roles.Visible = True Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Roles = New FrmRoles
            Roles.MdiParent = Me
            Roles.Show()
        End If
    End Sub

    Private Sub UnidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesToolStripMenuItem.Click
        If Unidades.Visible = True Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Unidades = New FrmUnidades
            Unidades.MdiParent = Me
            Unidades.Show()
        End If
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click
        If Estados.Visible = True Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Estados = New FrmEstados
            Estados.MdiParent = Me
            Estados.Show()
        End If
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        If FormasPago.Visible = True Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            FormasPago = New FrmFormaPag
            FormasPago.MdiParent = Me
            FormasPago.Show()
        End If
    End Sub

    Private Sub FacturacionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem1.Click
        If Categorias.Visible = True Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Categorias = New FrmCategorias
            Categorias.MdiParent = Me
            Categorias.Show()
        End If
    End Sub
    Private Sub FormasDePAgoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormasDePAgoToolStripMenuItem.Click
        If Categorias.Visible = True Then
            MsgBox("La ventana ya ha sido mostrada.")
        Else
            Categorias = New FrmCategorias
            Categorias.MdiParent = Me
            Categorias.Show()
        End If
    End Sub

    Private Sub FrmPrincipal_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub
End Class