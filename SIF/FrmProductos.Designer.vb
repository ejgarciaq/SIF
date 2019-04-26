<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.DGVusuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbprodEst = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBprodCan = New System.Windows.Forms.TextBox()
        Me.TBprodID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBprodCat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBprodUni = New System.Windows.Forms.TextBox()
        Me.CBprodPre = New System.Windows.Forms.ComboBox()
        Me.TBprodNom = New System.Windows.Forms.TextBox()
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVusuarios
        '
        Me.DGVusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVusuarios.Location = New System.Drawing.Point(540, 12)
        Me.DGVusuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVusuarios.Name = "DGVusuarios"
        Me.DGVusuarios.Size = New System.Drawing.Size(684, 325)
        Me.DGVusuarios.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbprodEst)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBprodCan)
        Me.GroupBox1.Controls.Add(Me.TBprodID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBprodCat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBprodUni)
        Me.GroupBox1.Controls.Add(Me.CBprodPre)
        Me.GroupBox1.Controls.Add(Me.TBprodNom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 326)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'cbprodEst
        '
        Me.cbprodEst.AutoSize = True
        Me.cbprodEst.Checked = True
        Me.cbprodEst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbprodEst.Location = New System.Drawing.Point(141, 217)
        Me.cbprodEst.Name = "cbprodEst"
        Me.cbprodEst.Size = New System.Drawing.Size(68, 21)
        Me.cbprodEst.TabIndex = 7
        Me.cbprodEst.Text = "Activo"
        Me.cbprodEst.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cantidad"
        '
        'TBprodCan
        '
        Me.TBprodCan.Location = New System.Drawing.Point(141, 150)
        Me.TBprodCan.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodCan.Name = "TBprodCan"
        Me.TBprodCan.Size = New System.Drawing.Size(353, 22)
        Me.TBprodCan.TabIndex = 5
        '
        'TBprodID
        '
        Me.TBprodID.Location = New System.Drawing.Point(141, 23)
        Me.TBprodID.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodID.Name = "TBprodID"
        Me.TBprodID.Size = New System.Drawing.Size(353, 22)
        Me.TBprodID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'TBprodCat
        '
        Me.TBprodCat.Location = New System.Drawing.Point(141, 54)
        Me.TBprodCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodCat.Name = "TBprodCat"
        Me.TBprodCat.Size = New System.Drawing.Size(353, 22)
        Me.TBprodCat.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Categoria"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 281)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Unidad"
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(24, 281)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(100, 28)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 217)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estado"
        '
        'TBprodUni
        '
        Me.TBprodUni.Location = New System.Drawing.Point(141, 86)
        Me.TBprodUni.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodUni.Name = "TBprodUni"
        Me.TBprodUni.Size = New System.Drawing.Size(353, 22)
        Me.TBprodUni.TabIndex = 3
        '
        'CBprodPre
        '
        Me.CBprodPre.FormattingEnabled = True
        Me.CBprodPre.Items.AddRange(New Object() {"1", "2"})
        Me.CBprodPre.Location = New System.Drawing.Point(141, 180)
        Me.CBprodPre.Margin = New System.Windows.Forms.Padding(4)
        Me.CBprodPre.Name = "CBprodPre"
        Me.CBprodPre.Size = New System.Drawing.Size(353, 24)
        Me.CBprodPre.TabIndex = 6
        '
        'TBprodNom
        '
        Me.TBprodNom.Location = New System.Drawing.Point(141, 118)
        Me.TBprodNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodNom.Name = "TBprodNom"
        Me.TBprodNom.Size = New System.Drawing.Size(353, 22)
        Me.TBprodNom.TabIndex = 4
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 352)
        Me.Controls.Add(Me.DGVusuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProductos"
        Me.Text = "FrmProductos"
        CType(Me.DGVusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVusuarios As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbprodEst As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBprodCan As TextBox
    Friend WithEvents TBprodID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBprodCat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNguardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBprodUni As TextBox
    Friend WithEvents CBprodPre As ComboBox
    Friend WithEvents TBprodNom As TextBox
End Class
