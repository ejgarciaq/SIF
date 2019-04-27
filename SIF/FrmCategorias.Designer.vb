<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategorias))
        Me.DGVcategoria = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCatEstado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCatID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCatDescrip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCattBorrar = New System.Windows.Forms.Button()
        Me.btnCatGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVcategoria
        '
        Me.DGVcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcategoria.Location = New System.Drawing.Point(428, 12)
        Me.DGVcategoria.Name = "DGVcategoria"
        Me.DGVcategoria.Size = New System.Drawing.Size(401, 260)
        Me.DGVcategoria.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCatEstado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbCatID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbCatDescrip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCattBorrar)
        Me.GroupBox1.Controls.Add(Me.btnCatGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 147)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Categoria"
        '
        'cbCatEstado
        '
        Me.cbCatEstado.AutoSize = True
        Me.cbCatEstado.Checked = True
        Me.cbCatEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCatEstado.Location = New System.Drawing.Point(106, 66)
        Me.cbCatEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCatEstado.Name = "cbCatEstado"
        Me.cbCatEstado.Size = New System.Drawing.Size(56, 17)
        Me.cbCatEstado.TabIndex = 18
        Me.cbCatEstado.Text = "Activo"
        Me.cbCatEstado.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Estado"
        '
        'tbCatID
        '
        Me.tbCatID.Location = New System.Drawing.Point(106, 15)
        Me.tbCatID.Name = "tbCatID"
        Me.tbCatID.Size = New System.Drawing.Size(266, 20)
        Me.tbCatID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbCatDescrip
        '
        Me.tbCatDescrip.Location = New System.Drawing.Point(106, 40)
        Me.tbCatDescrip.Name = "tbCatDescrip"
        Me.tbCatDescrip.Size = New System.Drawing.Size(266, 20)
        Me.tbCatDescrip.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción"
        '
        'btnCattBorrar
        '
        Me.btnCattBorrar.Location = New System.Drawing.Point(103, 96)
        Me.btnCattBorrar.Name = "btnCattBorrar"
        Me.btnCattBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCattBorrar.TabIndex = 9
        Me.btnCattBorrar.Text = "Borrar"
        Me.btnCattBorrar.UseVisualStyleBackColor = True
        '
        'btnCatGuardar
        '
        Me.btnCatGuardar.Location = New System.Drawing.Point(15, 96)
        Me.btnCatGuardar.Name = "btnCatGuardar"
        Me.btnCatGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnCatGuardar.TabIndex = 8
        Me.btnCatGuardar.Text = "Guardar"
        Me.btnCatGuardar.UseVisualStyleBackColor = True
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 283)
        Me.Controls.Add(Me.DGVcategoria)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias"
        CType(Me.DGVcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVcategoria As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbCatEstado As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCatID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCatDescrip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCattBorrar As Button
    Friend WithEvents btnCatGuardar As Button
End Class
