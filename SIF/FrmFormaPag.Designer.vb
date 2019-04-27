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
        Me.DGVformPago = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFormPagEstado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFormPagID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbFormPagDescrip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFormPagBorrar = New System.Windows.Forms.Button()
        Me.btnFormPagGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVformPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVformPago
        '
        Me.DGVformPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVformPago.Location = New System.Drawing.Point(396, 12)
        Me.DGVformPago.Name = "DGVformPago"
        Me.DGVformPago.Size = New System.Drawing.Size(433, 260)
        Me.DGVformPago.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFormPagEstado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbFormPagID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbFormPagDescrip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFormPagBorrar)
        Me.GroupBox1.Controls.Add(Me.btnFormPagGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 147)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Forma Pago"
        '
        'cbFormPagEstado
        '
        Me.cbFormPagEstado.AutoSize = True
        Me.cbFormPagEstado.Checked = True
        Me.cbFormPagEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFormPagEstado.Location = New System.Drawing.Point(106, 66)
        Me.cbFormPagEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbFormPagEstado.Name = "cbFormPagEstado"
        Me.cbFormPagEstado.Size = New System.Drawing.Size(56, 17)
        Me.cbFormPagEstado.TabIndex = 18
        Me.cbFormPagEstado.Text = "Activo"
        Me.cbFormPagEstado.UseVisualStyleBackColor = True
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
        'tbFormPagID
        '
        Me.tbFormPagID.Location = New System.Drawing.Point(106, 15)
        Me.tbFormPagID.Name = "tbFormPagID"
        Me.tbFormPagID.Size = New System.Drawing.Size(266, 20)
        Me.tbFormPagID.TabIndex = 1
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
        'tbFormPagDescrip
        '
        Me.tbFormPagDescrip.Location = New System.Drawing.Point(106, 40)
        Me.tbFormPagDescrip.Name = "tbFormPagDescrip"
        Me.tbFormPagDescrip.Size = New System.Drawing.Size(266, 20)
        Me.tbFormPagDescrip.TabIndex = 2
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
        'btnFormPagBorrar
        '
        Me.btnFormPagBorrar.Location = New System.Drawing.Point(103, 96)
        Me.btnFormPagBorrar.Name = "btnFormPagBorrar"
        Me.btnFormPagBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFormPagBorrar.TabIndex = 9
        Me.btnFormPagBorrar.Text = "Borrar"
        Me.btnFormPagBorrar.UseVisualStyleBackColor = True
        '
        'btnFormPagGuardar
        '
        Me.btnFormPagGuardar.Location = New System.Drawing.Point(15, 96)
        Me.btnFormPagGuardar.Name = "btnFormPagGuardar"
        Me.btnFormPagGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnFormPagGuardar.TabIndex = 8
        Me.btnFormPagGuardar.Text = "Guardar"
        Me.btnFormPagGuardar.UseVisualStyleBackColor = True
        '
        'FrmFormaPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 285)
        Me.Controls.Add(Me.DGVformPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFormaPag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas de Pago"
        CType(Me.DGVformPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVformPago As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbFormPagEstado As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbFormPagID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbFormPagDescrip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFormPagBorrar As Button
    Friend WithEvents btnFormPagGuardar As Button
End Class
