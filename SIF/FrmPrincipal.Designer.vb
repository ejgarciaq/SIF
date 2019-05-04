<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormasDePAgoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.tsConfiguracion, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.FacturacionToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.facturas
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(116, 24)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.FormasPago
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.facturas
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.inventario
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.inventario
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'tsConfiguracion
        '
        Me.tsConfiguracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.ProductosToolStripMenuItem1, Me.FacturacionToolStripMenuItem1})
        Me.tsConfiguracion.Image = Global.SIF.My.Resources.Resources.categorias
        Me.tsConfiguracion.Name = "tsConfiguracion"
        Me.tsConfiguracion.Size = New System.Drawing.Size(134, 24)
        Me.tsConfiguracion.Text = "Configuracion"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.usuarios
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'RolToolStripMenuItem
        '
        Me.RolToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.roles
        Me.RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        Me.RolToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.RolToolStripMenuItem.Text = "Roles"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.clientes
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.empresas
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EmpresaToolStripMenuItem.Text = "Locales"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadesToolStripMenuItem, Me.EstadosToolStripMenuItem, Me.CategoriasToolStripMenuItem})
        Me.ProductosToolStripMenuItem1.Image = Global.SIF.My.Resources.Resources.inventario
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'UnidadesToolStripMenuItem
        '
        Me.UnidadesToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.ud
        Me.UnidadesToolStripMenuItem.Name = "UnidadesToolStripMenuItem"
        Me.UnidadesToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.UnidadesToolStripMenuItem.Text = "Unidades"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.Estado
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.categorias
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'FacturacionToolStripMenuItem1
        '
        Me.FacturacionToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormasDePAgoToolStripMenuItem})
        Me.FacturacionToolStripMenuItem1.Image = Global.SIF.My.Resources.Resources.facturas
        Me.FacturacionToolStripMenuItem1.Name = "FacturacionToolStripMenuItem1"
        Me.FacturacionToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
        Me.FacturacionToolStripMenuItem1.Text = "Facturacion"
        '
        'FormasDePAgoToolStripMenuItem
        '
        Me.FormasDePAgoToolStripMenuItem.Image = Global.SIF.My.Resources.Resources.FormasPago
        Me.FormasDePAgoToolStripMenuItem.Name = "FormasDePAgoToolStripMenuItem"
        Me.FormasDePAgoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.FormasDePAgoToolStripMenuItem.Text = "Formas de Pago"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPrincipal"
        Me.ShowIcon = False
        Me.Text = "Sistema de Inventario y Facturación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsConfiguracion As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormasDePAgoToolStripMenuItem As ToolStripMenuItem
End Class
