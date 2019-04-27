<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.DGVusuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEstado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBclienteCorreo = New System.Windows.Forms.TextBox()
        Me.TBclienteID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBclienteName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBclienteDIreccion = New System.Windows.Forms.TextBox()
        Me.TBclienteTelefono = New System.Windows.Forms.TextBox()
        Me.TBclienteTotalCompra = New System.Windows.Forms.TextBox()
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVusuarios
        '
        Me.DGVusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVusuarios.Location = New System.Drawing.Point(416, 11)
        Me.DGVusuarios.Name = "DGVusuarios"
        Me.DGVusuarios.Size = New System.Drawing.Size(646, 264)
        Me.DGVusuarios.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBclienteTotalCompra)
        Me.GroupBox1.Controls.Add(Me.cbEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBclienteCorreo)
        Me.GroupBox1.Controls.Add(Me.TBclienteID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBclienteName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBclienteDIreccion)
        Me.GroupBox1.Controls.Add(Me.TBclienteTelefono)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 265)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Clientes"
        '
        'cbEstado
        '
        Me.cbEstado.AutoSize = True
        Me.cbEstado.Checked = True
        Me.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEstado.Location = New System.Drawing.Point(106, 176)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(56, 17)
        Me.cbEstado.TabIndex = 7
        Me.cbEstado.Text = "Activo"
        Me.cbEstado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Correo-E"
        '
        'TBclienteCorreo
        '
        Me.TBclienteCorreo.Location = New System.Drawing.Point(106, 122)
        Me.TBclienteCorreo.Name = "TBclienteCorreo"
        Me.TBclienteCorreo.Size = New System.Drawing.Size(266, 20)
        Me.TBclienteCorreo.TabIndex = 5
        '
        'TBclienteID
        '
        Me.TBclienteID.Location = New System.Drawing.Point(106, 19)
        Me.TBclienteID.Name = "TBclienteID"
        Me.TBclienteID.Size = New System.Drawing.Size(266, 20)
        Me.TBclienteID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'TBclienteName
        '
        Me.TBclienteName.Location = New System.Drawing.Point(106, 44)
        Me.TBclienteName.Name = "TBclienteName"
        Me.TBclienteName.Size = New System.Drawing.Size(266, 20)
        Me.TBclienteName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Dirección"
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(18, 228)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total Comprado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estado"
        '
        'TBclienteDIreccion
        '
        Me.TBclienteDIreccion.Location = New System.Drawing.Point(106, 70)
        Me.TBclienteDIreccion.Name = "TBclienteDIreccion"
        Me.TBclienteDIreccion.Size = New System.Drawing.Size(266, 20)
        Me.TBclienteDIreccion.TabIndex = 3
        '
        'TBclienteTelefono
        '
        Me.TBclienteTelefono.Location = New System.Drawing.Point(106, 96)
        Me.TBclienteTelefono.Name = "TBclienteTelefono"
        Me.TBclienteTelefono.Size = New System.Drawing.Size(266, 20)
        Me.TBclienteTelefono.TabIndex = 4
        '
        'TBclienteTotalCompra
        '
        Me.TBclienteTotalCompra.Location = New System.Drawing.Point(106, 148)
        Me.TBclienteTotalCompra.Name = "TBclienteTotalCompra"
        Me.TBclienteTotalCompra.Size = New System.Drawing.Size(266, 20)
        Me.TBclienteTotalCompra.TabIndex = 18
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 286)
        Me.Controls.Add(Me.DGVusuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVusuarios As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbEstado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBclienteCorreo As TextBox
    Friend WithEvents TBclienteID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBclienteName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNguardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBclienteDIreccion As TextBox
    Friend WithEvents TBclienteTelefono As TextBox
    Friend WithEvents TBclienteTotalCompra As TextBox
End Class
