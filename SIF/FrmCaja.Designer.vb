<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCaja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.cbLocal = New System.Windows.Forms.ComboBox()
        Me.tbFactura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nUD = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbProducto = New System.Windows.Forms.ListBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.label5 = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbFecha)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.cbUsuario)
        Me.GroupBox1.Controls.Add(Me.cbCliente)
        Me.GroupBox1.Controls.Add(Me.cbLocal)
        Me.GroupBox1.Controls.Add(Me.tbFactura)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(392, 225)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caja"
        '
        'cbUsuario
        '
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(180, 151)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(180, 24)
        Me.cbUsuario.TabIndex = 3
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(180, 109)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(180, 24)
        Me.cbCliente.TabIndex = 2
        '
        'cbLocal
        '
        Me.cbLocal.FormattingEnabled = True
        Me.cbLocal.Location = New System.Drawing.Point(180, 64)
        Me.cbLocal.Name = "cbLocal"
        Me.cbLocal.Size = New System.Drawing.Size(180, 24)
        Me.cbLocal.TabIndex = 1
        '
        'tbFactura
        '
        Me.tbFactura.Location = New System.Drawing.Point(180, 22)
        Me.tbFactura.Name = "tbFactura"
        Me.tbFactura.Size = New System.Drawing.Size(180, 22)
        Me.tbFactura.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Local"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Factura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nUD)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btAgregar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbProducto)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 218)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'nUD
        '
        Me.nUD.Location = New System.Drawing.Point(180, 116)
        Me.nUD.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nUD.Name = "nUD"
        Me.nUD.Size = New System.Drawing.Size(61, 22)
        Me.nUD.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(177, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cantidad"
        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(166, 158)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btAgregar.TabIndex = 2
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Seleccione un producto a agregar"
        '
        'lbProducto
        '
        Me.lbProducto.FormattingEnabled = True
        Me.lbProducto.ItemHeight = 16
        Me.lbProducto.Location = New System.Drawing.Point(11, 58)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(141, 148)
        Me.lbProducto.TabIndex = 0
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Enabled = False
        Me.btnFinalizar.Location = New System.Drawing.Point(279, 304)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(130, 45)
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "Finalizar Facturación"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(279, 367)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 45)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(57, 197)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 17)
        Me.label5.TabIndex = 5
        Me.label5.Tag = ""
        Me.label5.Text = "Fecha"
        '
        'tbFecha
        '
        Me.tbFecha.Location = New System.Drawing.Point(180, 196)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(180, 22)
        Me.tbFecha.TabIndex = 6
        Me.tbFecha.Text = "YYYY/MM/DD"
        '
        'FrmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmCaja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents cbLocal As ComboBox
    Friend WithEvents tbFactura As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nUD As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbProducto As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ErrDatos As ErrorProvider
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents label5 As Label
End Class
