﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBuserName = New System.Windows.Forms.TextBox()
        Me.TBuserPass = New System.Windows.Forms.TextBox()
        Me.TBuserPassConf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBuserEstado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBuserIntentos = New System.Windows.Forms.TextBox()
        Me.TBuserID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBuserRol = New System.Windows.Forms.ComboBox()
        Me.DGVusuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmar Clave"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rol"
        '
        'TBuserName
        '
        Me.TBuserName.Location = New System.Drawing.Point(106, 44)
        Me.TBuserName.Name = "TBuserName"
        Me.TBuserName.Size = New System.Drawing.Size(266, 20)
        Me.TBuserName.TabIndex = 4
        '
        'TBuserPass
        '
        Me.TBuserPass.Location = New System.Drawing.Point(106, 70)
        Me.TBuserPass.Name = "TBuserPass"
        Me.TBuserPass.Size = New System.Drawing.Size(266, 20)
        Me.TBuserPass.TabIndex = 5
        '
        'TBuserPassConf
        '
        Me.TBuserPassConf.Location = New System.Drawing.Point(106, 96)
        Me.TBuserPassConf.Name = "TBuserPassConf"
        Me.TBuserPassConf.Size = New System.Drawing.Size(266, 20)
        Me.TBuserPassConf.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado"
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(18, 228)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNguardar.TabIndex = 10
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBuserEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBuserIntentos)
        Me.GroupBox1.Controls.Add(Me.TBuserID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBuserName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBuserPass)
        Me.GroupBox1.Controls.Add(Me.CBuserRol)
        Me.GroupBox1.Controls.Add(Me.TBuserPassConf)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 265)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'CBuserEstado
        '
        Me.CBuserEstado.FormattingEnabled = True
        Me.CBuserEstado.Items.AddRange(New Object() {"0", "1"})
        Me.CBuserEstado.Location = New System.Drawing.Point(106, 173)
        Me.CBuserEstado.Name = "CBuserEstado"
        Me.CBuserEstado.Size = New System.Drawing.Size(266, 21)
        Me.CBuserEstado.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Intentos"
        '
        'TBuserIntentos
        '
        Me.TBuserIntentos.Location = New System.Drawing.Point(106, 122)
        Me.TBuserIntentos.Name = "TBuserIntentos"
        Me.TBuserIntentos.Size = New System.Drawing.Size(266, 20)
        Me.TBuserIntentos.TabIndex = 15
        '
        'TBuserID
        '
        Me.TBuserID.Location = New System.Drawing.Point(106, 19)
        Me.TBuserID.Name = "TBuserID"
        Me.TBuserID.Size = New System.Drawing.Size(266, 20)
        Me.TBuserID.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ID"
        '
        'CBuserRol
        '
        Me.CBuserRol.FormattingEnabled = True
        Me.CBuserRol.Items.AddRange(New Object() {"1", "2"})
        Me.CBuserRol.Location = New System.Drawing.Point(106, 146)
        Me.CBuserRol.Name = "CBuserRol"
        Me.CBuserRol.Size = New System.Drawing.Size(266, 21)
        Me.CBuserRol.TabIndex = 7
        '
        'DGVusuarios
        '
        Me.DGVusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVusuarios.Location = New System.Drawing.Point(416, 13)
        Me.DGVusuarios.Name = "DGVusuarios"
        Me.DGVusuarios.Size = New System.Drawing.Size(646, 264)
        Me.DGVusuarios.TabIndex = 14
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 286)
        Me.Controls.Add(Me.DGVusuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents TBuserName As TextBox
    Friend WithEvents TBuserPass As TextBox
    Friend WithEvents TBuserPassConf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BTNguardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVusuarios As DataGridView
    Friend WithEvents TBuserID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBuserIntentos As TextBox
    Friend WithEvents CBuserEstado As ComboBox
    Friend WithEvents CBuserRol As ComboBox
End Class
