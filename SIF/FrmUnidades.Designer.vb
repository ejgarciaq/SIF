<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUnidades))
        Me.DGVunidades = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUdCerrar = New System.Windows.Forms.Button()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTNguardar = New System.Windows.Forms.Button()
        CType(Me.DGVunidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVunidades
        '
        Me.DGVunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVunidades.Location = New System.Drawing.Point(13, 151)
        Me.DGVunidades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVunidades.Name = "DGVunidades"
        Me.DGVunidades.Size = New System.Drawing.Size(420, 217)
        Me.DGVunidades.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUdCerrar)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(417, 128)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Unidades"
        '
        'btnUdCerrar
        '
        Me.btnUdCerrar.Location = New System.Drawing.Point(303, 92)
        Me.btnUdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUdCerrar.Name = "btnUdCerrar"
        Me.btnUdCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnUdCerrar.TabIndex = 20
        Me.btnUdCerrar.Text = "Cerrar"
        Me.btnUdCerrar.UseVisualStyleBackColor = True
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(106, 21)
        Me.tbId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(189, 22)
        Me.tbId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(106, 59)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(189, 22)
        Me.tbDescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 56)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(303, 18)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(100, 28)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'FrmUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVunidades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmUnidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidades"
        CType(Me.DGVunidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVunidades As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BTNguardar As Button
    Friend WithEvents btnUdCerrar As Button
End Class
