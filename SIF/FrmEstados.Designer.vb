<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstados))
        Me.DGVestados = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnestadoCerrar = New System.Windows.Forms.Button()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEstBorrar = New System.Windows.Forms.Button()
        Me.btnEstguardar = New System.Windows.Forms.Button()
        CType(Me.DGVestados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVestados
        '
        Me.DGVestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVestados.Location = New System.Drawing.Point(16, 152)
        Me.DGVestados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVestados.Name = "DGVestados"
        Me.DGVestados.Size = New System.Drawing.Size(429, 222)
        Me.DGVestados.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnestadoCerrar)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnEstBorrar)
        Me.GroupBox1.Controls.Add(Me.btnEstguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(429, 129)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Estados"
        '
        'btnestadoCerrar
        '
        Me.btnestadoCerrar.Location = New System.Drawing.Point(321, 89)
        Me.btnestadoCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnestadoCerrar.Name = "btnestadoCerrar"
        Me.btnestadoCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnestadoCerrar.TabIndex = 20
        Me.btnestadoCerrar.Text = "Cerrar"
        Me.btnestadoCerrar.UseVisualStyleBackColor = True
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(122, 19)
        Me.tbId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(176, 22)
        Me.tbId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(122, 56)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(176, 22)
        Me.tbDescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción"
        '
        'btnEstBorrar
        '
        Me.btnEstBorrar.Location = New System.Drawing.Point(321, 53)
        Me.btnEstBorrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEstBorrar.Name = "btnEstBorrar"
        Me.btnEstBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnEstBorrar.TabIndex = 9
        Me.btnEstBorrar.Text = "Borrar"
        Me.btnEstBorrar.UseVisualStyleBackColor = True
        '
        'btnEstguardar
        '
        Me.btnEstguardar.Location = New System.Drawing.Point(321, 16)
        Me.btnEstguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEstguardar.Name = "btnEstguardar"
        Me.btnEstguardar.Size = New System.Drawing.Size(100, 28)
        Me.btnEstguardar.TabIndex = 8
        Me.btnEstguardar.Text = "Guardar"
        Me.btnEstguardar.UseVisualStyleBackColor = True
        '
        'FrmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVestados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmEstados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estados"
        CType(Me.DGVestados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVestados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEstBorrar As Button
    Friend WithEvents btnEstguardar As Button
    Friend WithEvents btnestadoCerrar As Button
End Class
