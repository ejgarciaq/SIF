<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbPasswordConf = New System.Windows.Forms.TextBox()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.btnUserBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbApellido2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbApellido1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.DGVusuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Confirmar Clave"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Rol"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(141, 49)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(353, 22)
        Me.tbNombre.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(141, 177)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(353, 22)
        Me.tbPassword.TabIndex = 3
        '
        'tbPasswordConf
        '
        Me.tbPasswordConf.Location = New System.Drawing.Point(141, 209)
        Me.tbPasswordConf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPasswordConf.Name = "tbPasswordConf"
        Me.tbPasswordConf.Size = New System.Drawing.Size(353, 22)
        Me.tbPasswordConf.TabIndex = 4
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(20, 274)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(100, 28)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'btnUserBorrar
        '
        Me.btnUserBorrar.Location = New System.Drawing.Point(137, 274)
        Me.btnUserBorrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUserBorrar.Name = "btnUserBorrar"
        Me.btnUserBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnUserBorrar.TabIndex = 9
        Me.btnUserBorrar.Text = "Borrar"
        Me.btnUserBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbUserName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbApellido2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbApellido1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnUserBorrar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbPassword)
        Me.GroupBox1.Controls.Add(Me.cbRol)
        Me.GroupBox1.Controls.Add(Me.tbPasswordConf)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 382)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Usuarios"
        '
        'tbUserName
        '
        Me.tbUserName.Location = New System.Drawing.Point(141, 145)
        Me.tbUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(353, 22)
        Me.tbUserName.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "UserName"
        '
        'tbApellido2
        '
        Me.tbApellido2.Location = New System.Drawing.Point(141, 113)
        Me.tbApellido2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbApellido2.Name = "tbApellido2"
        Me.tbApellido2.Size = New System.Drawing.Size(353, 22)
        Me.tbApellido2.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 117)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Apellido2"
        '
        'tbApellido1
        '
        Me.tbApellido1.Location = New System.Drawing.Point(141, 81)
        Me.tbApellido1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbApellido1.Name = "tbApellido1"
        Me.tbApellido1.Size = New System.Drawing.Size(353, 22)
        Me.tbApellido1.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 85)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Apellido1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(301, 274)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(195, 92)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = "Requisitos para la clave:" & Global.Microsoft.VisualBasic.ChrW(10) & " - Mínimo 8 caracteres" & Global.Microsoft.VisualBasic.ChrW(10) & " - Mínimo 1 letra mayúscula" & Global.Microsoft.VisualBasic.ChrW(10) & " - M" &
    "ínimo 1 numero" & Global.Microsoft.VisualBasic.ChrW(10) & " - Mínimo 1 carácter especial"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(141, 18)
        Me.tbID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(353, 22)
        Me.tbID.TabIndex = 1
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
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"1", "2"})
        Me.cbRol.Location = New System.Drawing.Point(141, 241)
        Me.cbRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(353, 24)
        Me.cbRol.TabIndex = 6
        '
        'DGVusuarios
        '
        Me.DGVusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVusuarios.Location = New System.Drawing.Point(555, 16)
        Me.DGVusuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVusuarios.Name = "DGVusuarios"
        Me.DGVusuarios.Size = New System.Drawing.Size(924, 366)
        Me.DGVusuarios.TabIndex = 10
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1495, 412)
        Me.Controls.Add(Me.DGVusuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbPasswordConf As TextBox
    Friend WithEvents BTNguardar As Button
    Friend WithEvents btnUserBorrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVusuarios As DataGridView
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents tbApellido2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbApellido1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbUserName As TextBox
    Friend WithEvents Label10 As Label
End Class
