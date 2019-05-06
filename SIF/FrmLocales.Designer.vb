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
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTNguardar = New System.Windows.Forms.Button()
        CType(Me.DGVlocales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVlocales
        '
        Me.DGVlocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlocales.Location = New System.Drawing.Point(11, 153)
        Me.DGVlocales.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVlocales.Name = "DGVlocales"
        Me.DGVlocales.Size = New System.Drawing.Size(434, 269)
        Me.DGVlocales.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLocalCerrar)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(434, 133)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dato de Locales"
        '
        'btnLocalCerrar
        '
        Me.btnLocalCerrar.Location = New System.Drawing.Point(324, 92)
        Me.btnLocalCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLocalCerrar.Name = "btnLocalCerrar"
        Me.btnLocalCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnLocalCerrar.TabIndex = 18
        Me.btnLocalCerrar.Text = "Cerrar"
        Me.btnLocalCerrar.UseVisualStyleBackColor = True
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(100, 23)
        Me.tbId.Margin = New System.Windows.Forms.Padding(4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(204, 22)
        Me.tbId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(100, 59)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(204, 22)
        Me.tbNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(324, 56)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(324, 20)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(100, 28)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'FrmLocales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVlocales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BTNguardar As Button
    Friend WithEvents btnLocalCerrar As Button
End Class
