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
        Me.DGVproductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProdCerrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGVproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVproductos
        '
        Me.DGVproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVproductos.Location = New System.Drawing.Point(14, 183)
        Me.DGVproductos.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DGVproductos.Name = "DGVproductos"
        Me.DGVproductos.Size = New System.Drawing.Size(648, 234)
        Me.DGVproductos.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbEstado)
        Me.GroupBox1.Controls.Add(Me.cbCategoria)
        Me.GroupBox1.Controls.Add(Me.btnProdCerrar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbCantidad)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNguardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.cbUnidad)
        Me.GroupBox1.Controls.Add(Me.tbPrecio)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(646, 158)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'btnProdCerrar
        '
        Me.btnProdCerrar.Location = New System.Drawing.Point(535, 119)
        Me.btnProdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProdCerrar.Name = "btnProdCerrar"
        Me.btnProdCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnProdCerrar.TabIndex = 18
        Me.btnProdCerrar.Text = "Cerrar"
        Me.btnProdCerrar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 87)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cantidad"
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(97, 84)
        Me.tbCantidad.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(207, 22)
        Me.tbCantidad.TabIndex = 5
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(97, 20)
        Me.tbId.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(207, 22)
        Me.tbId.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Categoria"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(427, 119)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Unidad"
        '
        'BTNguardar
        '
        Me.BTNguardar.Location = New System.Drawing.Point(319, 119)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(100, 28)
        Me.BTNguardar.TabIndex = 8
        Me.BTNguardar.Text = "Guardar"
        Me.BTNguardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Precio Ud"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(97, 52)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(207, 22)
        Me.tbNombre.TabIndex = 3
        '
        'cbUnidad
        '
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Items.AddRange(New Object() {"1", "2"})
        Me.cbUnidad.Location = New System.Drawing.Point(395, 52)
        Me.cbUnidad.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(240, 24)
        Me.cbUnidad.TabIndex = 6
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(96, 116)
        Me.tbPrecio.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(207, 22)
        Me.tbPrecio.TabIndex = 4
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(395, 20)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(240, 24)
        Me.cbCategoria.TabIndex = 19
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(395, 84)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(240, 24)
        Me.cbEstado.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Estado"
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVproductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.DGVproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVproductos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents tbId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNguardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents btnProdCerrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents cbCategoria As ComboBox
End Class
