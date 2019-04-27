<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Me.DGVprodutos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbProdEst = New System.Windows.Forms.CheckBox()
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
        Me.TBprodNom = New System.Windows.Forms.TextBox()
        Me.TBprodUni = New System.Windows.Forms.ComboBox()
        Me.CBprodPre = New System.Windows.Forms.TextBox()
        CType(Me.DGVprodutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVprodutos
        '
        Me.DGVprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVprodutos.Location = New System.Drawing.Point(540, 12)
        Me.DGVprodutos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVprodutos.Name = "DGVprodutos"
        Me.DGVprodutos.Size = New System.Drawing.Size(684, 325)
        Me.DGVprodutos.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbProdEst)
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
        Me.GroupBox1.Controls.Add(Me.TBprodNom)
        Me.GroupBox1.Controls.Add(Me.TBprodUni)
        Me.GroupBox1.Controls.Add(Me.CBprodPre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 142)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'cbProdEst
        '
        Me.cbProdEst.AutoSize = True
        Me.cbProdEst.Checked = True
        Me.cbProdEst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbProdEst.Location = New System.Drawing.Point(296, 101)
        Me.cbProdEst.Name = "cbProdEst"
        Me.cbProdEst.Size = New System.Drawing.Size(56, 17)
        Me.cbProdEst.TabIndex = 7
        Me.cbProdEst.Text = "Activo"
        Me.cbProdEst.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cantidad"
        '
        'TBprodCan
        '
        Me.TBprodCan.Location = New System.Drawing.Point(73, 74)
        Me.TBprodCan.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodCan.Name = "TBprodCan"
        Me.TBprodCan.Size = New System.Drawing.Size(156, 20)
        Me.TBprodCan.TabIndex = 5
        '
        'TBprodID
        '
        Me.TBprodID.Location = New System.Drawing.Point(73, 19)
        Me.TBprodID.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodID.Name = "TBprodID"
        Me.TBprodID.Size = New System.Drawing.Size(156, 20)
        Me.TBprodID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'TBprodCat
        '
        Me.TBprodCat.Location = New System.Drawing.Point(296, 19)
        Me.TBprodCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodCat.Name = "TBprodCat"
        Me.TBprodCat.Size = New System.Drawing.Size(214, 20)
        Me.TBprodCat.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Categoria"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Unidad"
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(35, 101)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(75, 23)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Precio Ud"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estado"
        '
        'TBprodNom
        '
        Me.TBprodNom.Location = New System.Drawing.Point(74, 45)
        Me.TBprodNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodNom.Name = "TBprodNom"
        Me.TBprodNom.Size = New System.Drawing.Size(156, 20)
        Me.TBprodNom.TabIndex = 3
        '
        'TBprodUni
        '
        Me.TBprodUni.FormattingEnabled = True
        Me.TBprodUni.Items.AddRange(New Object() {"1", "2"})
        Me.TBprodUni.Location = New System.Drawing.Point(296, 45)
        Me.TBprodUni.Margin = New System.Windows.Forms.Padding(4)
        Me.TBprodUni.Name = "TBprodUni"
        Me.TBprodUni.Size = New System.Drawing.Size(214, 21)
        Me.TBprodUni.TabIndex = 6
        '
        'CBprodPre
        '
        Me.CBprodPre.Location = New System.Drawing.Point(296, 74)
        Me.CBprodPre.Margin = New System.Windows.Forms.Padding(4)
        Me.CBprodPre.Name = "CBprodPre"
        Me.CBprodPre.Size = New System.Drawing.Size(214, 20)
        Me.CBprodPre.TabIndex = 4
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 350)
        Me.Controls.Add(Me.DGVprodutos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.DGVprodutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVprodutos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbProdEst As CheckBox
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
    Friend WithEvents TBprodNom As TextBox
    Friend WithEvents TBprodUni As ComboBox
    Friend WithEvents CBprodPre As TextBox
End Class
