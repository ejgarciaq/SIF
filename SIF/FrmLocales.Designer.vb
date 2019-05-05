<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLocales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLocales))
        Me.DGVlocales = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLocalCerrar = New System.Windows.Forms.Button()
        Me.cbLocalEstado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbLocalAddress = New System.Windows.Forms.TextBox()
        Me.tbLocalId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbLocalName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbLocalPhone = New System.Windows.Forms.TextBox()
        Me.tbLocalMail = New System.Windows.Forms.TextBox()
        CType(Me.DGVlocales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVlocales
        '
        Me.DGVlocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlocales.Location = New System.Drawing.Point(412, 11)
        Me.DGVlocales.Name = "DGVlocales"
        Me.DGVlocales.Size = New System.Drawing.Size(646, 264)
        Me.DGVlocales.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLocalCerrar)
        Me.GroupBox1.Controls.Add(Me.cbLocalEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbLocalAddress)
        Me.GroupBox1.Controls.Add(Me.tbLocalId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbLocalName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbLocalPhone)
        Me.GroupBox1.Controls.Add(Me.tbLocalMail)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 265)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dato de Locales"
        '
        'btnLocalCerrar
        '
        Me.btnLocalCerrar.Location = New System.Drawing.Point(297, 184)
        Me.btnLocalCerrar.Name = "btnLocalCerrar"
        Me.btnLocalCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnLocalCerrar.TabIndex = 18
        Me.btnLocalCerrar.Text = "Cerrar"
        Me.btnLocalCerrar.UseVisualStyleBackColor = True
        '
        'cbLocalEstado
        '
        Me.cbLocalEstado.AutoSize = True
        Me.cbLocalEstado.Checked = True
        Me.cbLocalEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLocalEstado.Location = New System.Drawing.Point(106, 149)
        Me.cbLocalEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbLocalEstado.Name = "cbLocalEstado"
        Me.cbLocalEstado.Size = New System.Drawing.Size(56, 17)
        Me.cbLocalEstado.TabIndex = 7
        Me.cbLocalEstado.Text = "Activo"
        Me.cbLocalEstado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Dirección"
        '
        'tbLocalAddress
        '
        Me.tbLocalAddress.Location = New System.Drawing.Point(106, 122)
        Me.tbLocalAddress.Name = "tbLocalAddress"
        Me.tbLocalAddress.Size = New System.Drawing.Size(266, 20)
        Me.tbLocalAddress.TabIndex = 5
        '
        'tbLocalId
        '
        Me.tbLocalId.Location = New System.Drawing.Point(106, 19)
        Me.tbLocalId.Name = "tbLocalId"
        Me.tbLocalId.Size = New System.Drawing.Size(266, 20)
        Me.tbLocalId.TabIndex = 1
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
        'tbLocalName
        '
        Me.tbLocalName.Location = New System.Drawing.Point(106, 44)
        Me.tbLocalName.Name = "tbLocalName"
        Me.tbLocalName.Size = New System.Drawing.Size(266, 20)
        Me.tbLocalName.TabIndex = 2
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
        Me.Button2.Location = New System.Drawing.Point(106, 184)
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
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Teléfono"
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(18, 184)
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
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Correo-E"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estado"
        '
        'tbLocalPhone
        '
        Me.tbLocalPhone.Location = New System.Drawing.Point(106, 70)
        Me.tbLocalPhone.Name = "tbLocalPhone"
        Me.tbLocalPhone.Size = New System.Drawing.Size(266, 20)
        Me.tbLocalPhone.TabIndex = 3
        '
        'tbLocalMail
        '
        Me.tbLocalMail.Location = New System.Drawing.Point(106, 96)
        Me.tbLocalMail.Name = "tbLocalMail"
        Me.tbLocalMail.Size = New System.Drawing.Size(266, 20)
        Me.tbLocalMail.TabIndex = 4
        '
        'FrmLocales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVlocales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmLocales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locales"
        CType(Me.DGVlocales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVlocales As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbLocalEstado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbLocalAddress As TextBox
    Friend WithEvents tbLocalId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbLocalName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNguardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbLocalPhone As TextBox
    Friend WithEvents tbLocalMail As TextBox
    Friend WithEvents btnLocalCerrar As Button
End Class
