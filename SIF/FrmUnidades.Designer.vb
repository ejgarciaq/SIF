﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUnidades))
        Me.DGVunidades = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUdCerrar = New System.Windows.Forms.Button()
        Me.cbUdEstado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbUdID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbUdDescrip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTNguardar = New System.Windows.Forms.Button()
        CType(Me.DGVunidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVunidades
        '
        Me.DGVunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVunidades.Location = New System.Drawing.Point(396, 12)
        Me.DGVunidades.Name = "DGVunidades"
        Me.DGVunidades.Size = New System.Drawing.Size(433, 260)
        Me.DGVunidades.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUdCerrar)
        Me.GroupBox1.Controls.Add(Me.cbUdEstado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbUdID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbUdDescrip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 147)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Unidades"
        '
        'btnUdCerrar
        '
        Me.btnUdCerrar.Location = New System.Drawing.Point(297, 96)
        Me.btnUdCerrar.Name = "btnUdCerrar"
        Me.btnUdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnUdCerrar.TabIndex = 20
        Me.btnUdCerrar.Text = "Cerrar"
        Me.btnUdCerrar.UseVisualStyleBackColor = True
        '
        'cbUdEstado
        '
        Me.cbUdEstado.AutoSize = True
        Me.cbUdEstado.Checked = True
        Me.cbUdEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUdEstado.Location = New System.Drawing.Point(106, 66)
        Me.cbUdEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbUdEstado.Name = "cbUdEstado"
        Me.cbUdEstado.Size = New System.Drawing.Size(56, 17)
        Me.cbUdEstado.TabIndex = 18
        Me.cbUdEstado.Text = "Activo"
        Me.cbUdEstado.UseVisualStyleBackColor = True
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
        'tbUdID
        '
        Me.tbUdID.Location = New System.Drawing.Point(106, 15)
        Me.tbUdID.Name = "tbUdID"
        Me.tbUdID.Size = New System.Drawing.Size(266, 20)
        Me.tbUdID.TabIndex = 1
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
        'tbUdDescrip
        '
        Me.tbUdDescrip.Location = New System.Drawing.Point(106, 40)
        Me.tbUdDescrip.Name = "tbUdDescrip"
        Me.tbUdDescrip.Size = New System.Drawing.Size(266, 20)
        Me.tbUdDescrip.TabIndex = 2
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(15, 96)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'FrmUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 282)
        Me.Controls.Add(Me.DGVunidades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUnidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidades"
        CType(Me.DGVunidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVunidades As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbUdEstado As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbUdID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbUdDescrip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BTNguardar As Button
    Friend WithEvents btnUdCerrar As Button
End Class
