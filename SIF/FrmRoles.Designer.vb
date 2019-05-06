<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoles))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRolesCerrar = New System.Windows.Forms.Button()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRolesBorrar = New System.Windows.Forms.Button()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.DGVroles = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVroles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRolesCerrar)
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnRolesBorrar)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(420, 136)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Roles"
        '
        'btnRolesCerrar
        '
        Me.btnRolesCerrar.Location = New System.Drawing.Point(310, 100)
        Me.btnRolesCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRolesCerrar.Name = "btnRolesCerrar"
        Me.btnRolesCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnRolesCerrar.TabIndex = 20
        Me.btnRolesCerrar.Text = "Cerrar"
        Me.btnRolesCerrar.UseVisualStyleBackColor = True
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(102, 23)
        Me.tbID.Margin = New System.Windows.Forms.Padding(4)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(200, 22)
        Me.tbID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(102, 64)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(200, 22)
        Me.tbDescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción"
        '
        'btnRolesBorrar
        '
        Me.btnRolesBorrar.Location = New System.Drawing.Point(310, 61)
        Me.btnRolesBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRolesBorrar.Name = "btnRolesBorrar"
        Me.btnRolesBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnRolesBorrar.TabIndex = 9
        Me.btnRolesBorrar.Text = "Borrar"
        Me.btnRolesBorrar.UseVisualStyleBackColor = True
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(310, 20)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(100, 28)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'DGVroles
        '
        Me.DGVroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVroles.Location = New System.Drawing.Point(16, 159)
        Me.DGVroles.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVroles.Name = "DGVroles"
        Me.DGVroles.Size = New System.Drawing.Size(420, 283)
        Me.DGVroles.TabIndex = 20
        '
        'FrmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVroles)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVroles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRolesBorrar As Button
    Friend WithEvents BTNguardar As Button
    Friend WithEvents DGVroles As DataGridView
    Friend WithEvents btnRolesCerrar As Button
End Class
