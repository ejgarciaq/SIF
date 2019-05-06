<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.DGVclientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClienCerrar = New System.Windows.Forms.Button()
        Me.tbApellido2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbApellido1 = New System.Windows.Forms.TextBox()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTNguardar = New System.Windows.Forms.Button()
        CType(Me.DGVclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVclientes
        '
        Me.DGVclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVclientes.Location = New System.Drawing.Point(15, 174)
        Me.DGVclientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVclientes.Name = "DGVclientes"
        Me.DGVclientes.Size = New System.Drawing.Size(504, 251)
        Me.DGVclientes.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClienCerrar)
        Me.GroupBox1.Controls.Add(Me.tbApellido2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbApellido1)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 154)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Clientes"
        '
        'btnClienCerrar
        '
        Me.btnClienCerrar.Location = New System.Drawing.Point(395, 115)
        Me.btnClienCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClienCerrar.Name = "btnClienCerrar"
        Me.btnClienCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnClienCerrar.TabIndex = 23
        Me.btnClienCerrar.Text = "Cerrar"
        Me.btnClienCerrar.UseVisualStyleBackColor = True
        '
        'tbApellido2
        '
        Me.tbApellido2.Location = New System.Drawing.Point(352, 85)
        Me.tbApellido2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbApellido2.Name = "tbApellido2"
        Me.tbApellido2.Size = New System.Drawing.Size(143, 22)
        Me.tbApellido2.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(279, 88)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Apellido 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Apellido1"
        '
        'tbApellido1
        '
        Me.tbApellido1.Location = New System.Drawing.Point(128, 85)
        Me.tbApellido1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbApellido1.Name = "tbApellido1"
        Me.tbApellido1.Size = New System.Drawing.Size(143, 22)
        Me.tbApellido1.TabIndex = 19
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(128, 23)
        Me.tbId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(367, 22)
        Me.tbId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(128, 54)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(367, 22)
        Me.tbNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 115)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(43, 115)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(100, 28)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 438)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVclientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DGVclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVclientes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BTNguardar As Button
    Friend WithEvents tbApellido2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbApellido1 As TextBox
    Friend WithEvents btnClienCerrar As Button
End Class
