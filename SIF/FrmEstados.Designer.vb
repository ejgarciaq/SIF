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
        Me.cbEstEstado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEstID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbEstDescrip = New System.Windows.Forms.TextBox()
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
        Me.DGVestados.Location = New System.Drawing.Point(396, 12)
        Me.DGVestados.Name = "DGVestados"
        Me.DGVestados.Size = New System.Drawing.Size(433, 260)
        Me.DGVestados.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnestadoCerrar)
        Me.GroupBox1.Controls.Add(Me.cbEstEstado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbEstID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbEstDescrip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnEstBorrar)
        Me.GroupBox1.Controls.Add(Me.btnEstguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 131)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Estados"
        '
        'btnestadoCerrar
        '
        Me.btnestadoCerrar.Location = New System.Drawing.Point(297, 96)
        Me.btnestadoCerrar.Name = "btnestadoCerrar"
        Me.btnestadoCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnestadoCerrar.TabIndex = 20
        Me.btnestadoCerrar.Text = "Cerrar"
        Me.btnestadoCerrar.UseVisualStyleBackColor = True
        '
        'cbEstEstado
        '
        Me.cbEstEstado.AutoSize = True
        Me.cbEstEstado.Checked = True
        Me.cbEstEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEstEstado.Location = New System.Drawing.Point(106, 66)
        Me.cbEstEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbEstEstado.Name = "cbEstEstado"
        Me.cbEstEstado.Size = New System.Drawing.Size(56, 17)
        Me.cbEstEstado.TabIndex = 18
        Me.cbEstEstado.Text = "Activo"
        Me.cbEstEstado.UseVisualStyleBackColor = True
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
        'tbEstID
        '
        Me.tbEstID.Location = New System.Drawing.Point(106, 15)
        Me.tbEstID.Name = "tbEstID"
        Me.tbEstID.Size = New System.Drawing.Size(266, 20)
        Me.tbEstID.TabIndex = 1
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
        'tbEstDescrip
        '
        Me.tbEstDescrip.Location = New System.Drawing.Point(106, 40)
        Me.tbEstDescrip.Name = "tbEstDescrip"
        Me.tbEstDescrip.Size = New System.Drawing.Size(266, 20)
        Me.tbEstDescrip.TabIndex = 2
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
        'btnEstBorrar
        '
        Me.btnEstBorrar.Location = New System.Drawing.Point(103, 96)
        Me.btnEstBorrar.Name = "btnEstBorrar"
        Me.btnEstBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEstBorrar.TabIndex = 9
        Me.btnEstBorrar.Text = "Borrar"
        Me.btnEstBorrar.UseVisualStyleBackColor = True
        '
        'btnEstguardar
        '
        Me.btnEstguardar.Location = New System.Drawing.Point(15, 96)
        Me.btnEstguardar.Name = "btnEstguardar"
        Me.btnEstguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnEstguardar.TabIndex = 8
        Me.btnEstguardar.Text = "Guardar"
        Me.btnEstguardar.UseVisualStyleBackColor = True
        '
        'FrmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVestados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents cbEstEstado As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEstID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbEstDescrip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEstBorrar As Button
    Friend WithEvents btnEstguardar As Button
    Friend WithEvents btnestadoCerrar As Button
End Class
