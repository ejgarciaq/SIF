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
        Me.btnCatBorrar = New System.Windows.Forms.Button()
        Me.btnCatGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVcategoria
        '
        Me.DGVcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcategoria.Location = New System.Drawing.Point(528, 15)
        Me.DGVcategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVcategoria.Name = "DGVcategoria"
        Me.DGVcategoria.Size = New System.Drawing.Size(577, 320)
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
        Me.GroupBox1.Controls.Add(Me.btnCatBorrar)
        Me.GroupBox1.Controls.Add(Me.btnCatGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 181)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Categoria"
        '
        'cbCatEstado
        '
        Me.cbCatEstado.AutoSize = True
        Me.cbCatEstado.Checked = True
        Me.cbCatEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCatEstado.Location = New System.Drawing.Point(141, 81)
        Me.cbCatEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCatEstado.Name = "cbCatEstado"
        Me.cbCatEstado.Size = New System.Drawing.Size(68, 21)
        Me.cbCatEstado.TabIndex = 18
        Me.cbCatEstado.Text = "Activo"
        Me.cbCatEstado.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Estado"
        '
        'tbCatID
        '
        Me.tbCatID.Location = New System.Drawing.Point(141, 18)
        Me.tbCatID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCatID.Name = "tbCatID"
        Me.tbCatID.Size = New System.Drawing.Size(353, 22)
        Me.tbCatID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbCatDescrip
        '
        Me.tbCatDescrip.Location = New System.Drawing.Point(141, 49)
        Me.tbCatDescrip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCatDescrip.Name = "tbCatDescrip"
        Me.tbCatDescrip.Size = New System.Drawing.Size(353, 22)
        Me.tbCatDescrip.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción"
        '
        'btnCatBorrar
        '
        Me.btnCatBorrar.Location = New System.Drawing.Point(137, 118)
        Me.btnCatBorrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCatBorrar.Name = "btnCatBorrar"
        Me.btnCatBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnCatBorrar.TabIndex = 9
        Me.btnCatBorrar.Text = "Borrar"
        Me.btnCatBorrar.UseVisualStyleBackColor = True
        '
        'btnCatGuardar
        '
        Me.btnCatGuardar.Location = New System.Drawing.Point(20, 118)
        Me.btnCatGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.ClientSize = New System.Drawing.Size(1116, 348)
        Me.Controls.Add(Me.DGVcategoria)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents btnCatBorrar As Button
    Friend WithEvents btnCatGuardar As Button
End Class
