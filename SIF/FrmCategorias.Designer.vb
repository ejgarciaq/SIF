<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategorias))
        Me.DGVcategorias = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCatBorrar = New System.Windows.Forms.Button()
        Me.btnCatGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVcategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVcategorias
        '
        Me.DGVcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcategorias.Location = New System.Drawing.Point(16, 152)
        Me.DGVcategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVcategorias.Name = "DGVcategorias"
        Me.DGVcategorias.Size = New System.Drawing.Size(395, 185)
        Me.DGVcategorias.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCatBorrar)
        Me.GroupBox1.Controls.Add(Me.btnCatGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(395, 129)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Categoria"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(284, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(98, 21)
        Me.tbId.Margin = New System.Windows.Forms.Padding(4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(178, 22)
        Me.tbId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(98, 58)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(178, 22)
        Me.tbDescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción"
        '
        'btnCatBorrar
        '
        Me.btnCatBorrar.Location = New System.Drawing.Point(284, 55)
        Me.btnCatBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCatBorrar.Name = "btnCatBorrar"
        Me.btnCatBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnCatBorrar.TabIndex = 9
        Me.btnCatBorrar.Text = "Borrar"
        Me.btnCatBorrar.UseVisualStyleBackColor = True
        '
        'btnCatGuardar
        '
        Me.btnCatGuardar.Location = New System.Drawing.Point(284, 18)
        Me.btnCatGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCatGuardar.Name = "btnCatGuardar"
        Me.btnCatGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnCatGuardar.TabIndex = 8
        Me.btnCatGuardar.Text = "Guardar"
        Me.btnCatGuardar.UseVisualStyleBackColor = True
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVcategorias)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias"
        CType(Me.DGVcategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVcategorias As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCatBorrar As Button
    Friend WithEvents btnCatGuardar As Button
    Friend WithEvents Button1 As Button
End Class
