<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFormaPag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFormaPag))
        Me.DGVformapagos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFormPagCerrar = New System.Windows.Forms.Button()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFormPagBorrar = New System.Windows.Forms.Button()
        Me.btnFormPagGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVformapagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVformapagos
        '
        Me.DGVformapagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVformapagos.Location = New System.Drawing.Point(13, 156)
        Me.DGVformapagos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVformapagos.Name = "DGVformapagos"
        Me.DGVformapagos.Size = New System.Drawing.Size(424, 283)
        Me.DGVformapagos.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFormPagCerrar)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFormPagBorrar)
        Me.GroupBox1.Controls.Add(Me.btnFormPagGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(421, 133)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Forma Pago"
        '
        'btnFormPagCerrar
        '
        Me.btnFormPagCerrar.Location = New System.Drawing.Point(314, 95)
        Me.btnFormPagCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFormPagCerrar.Name = "btnFormPagCerrar"
        Me.btnFormPagCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnFormPagCerrar.TabIndex = 20
        Me.btnFormPagCerrar.Text = "Cerrar"
        Me.btnFormPagCerrar.UseVisualStyleBackColor = True
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(116, 26)
        Me.tbId.Margin = New System.Windows.Forms.Padding(4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(180, 22)
        Me.tbId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(116, 62)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(180, 22)
        Me.tbDescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción"
        '
        'btnFormPagBorrar
        '
        Me.btnFormPagBorrar.Location = New System.Drawing.Point(314, 59)
        Me.btnFormPagBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFormPagBorrar.Name = "btnFormPagBorrar"
        Me.btnFormPagBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnFormPagBorrar.TabIndex = 9
        Me.btnFormPagBorrar.Text = "Borrar"
        Me.btnFormPagBorrar.UseVisualStyleBackColor = True
        '
        'btnFormPagGuardar
        '
        Me.btnFormPagGuardar.Location = New System.Drawing.Point(314, 23)
        Me.btnFormPagGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFormPagGuardar.Name = "btnFormPagGuardar"
        Me.btnFormPagGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnFormPagGuardar.TabIndex = 8
        Me.btnFormPagGuardar.Text = "Guardar"
        Me.btnFormPagGuardar.UseVisualStyleBackColor = True
        '
        'FrmFormaPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVformapagos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFormaPag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas de Pago"
        CType(Me.DGVformapagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVformapagos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFormPagBorrar As Button
    Friend WithEvents btnFormPagGuardar As Button
    Friend WithEvents btnFormPagCerrar As Button
End Class
