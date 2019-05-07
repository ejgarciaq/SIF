<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturas))
        Me.DGVfacturas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFactCerrar = New System.Windows.Forms.Button()
        Me.tbFacTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBFacFecha = New System.Windows.Forms.TextBox()
        Me.TBfacID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBfacLocal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFacBorrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFacGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBfacIdClient = New System.Windows.Forms.TextBox()
        Me.tbFacClientName = New System.Windows.Forms.TextBox()
        Me.DGVdetalle = New System.Windows.Forms.DataGridView()
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVfacturas
        '
        Me.DGVfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfacturas.Location = New System.Drawing.Point(525, 22)
        Me.DGVfacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVfacturas.Name = "DGVfacturas"
        Me.DGVfacturas.Size = New System.Drawing.Size(480, 249)
        Me.DGVfacturas.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFactCerrar)
        Me.GroupBox1.Controls.Add(Me.tbFacTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBFacFecha)
        Me.GroupBox1.Controls.Add(Me.TBfacID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBfacLocal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFacBorrar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnFacGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBfacIdClient)
        Me.GroupBox1.Controls.Add(Me.tbFacClientName)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 259)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas"
        '
        'btnFactCerrar
        '
        Me.btnFactCerrar.Location = New System.Drawing.Point(388, 218)
        Me.btnFactCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFactCerrar.Name = "btnFactCerrar"
        Me.btnFactCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnFactCerrar.TabIndex = 19
        Me.btnFactCerrar.Text = "Cerrar"
        Me.btnFactCerrar.UseVisualStyleBackColor = True
        '
        'tbFacTotal
        '
        Me.tbFacTotal.Location = New System.Drawing.Point(141, 186)
        Me.tbFacTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFacTotal.Name = "tbFacTotal"
        Me.tbFacTotal.Size = New System.Drawing.Size(353, 22)
        Me.tbFacTotal.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha"
        '
        'TBFacFecha
        '
        Me.TBFacFecha.Location = New System.Drawing.Point(141, 150)
        Me.TBFacFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.TBFacFecha.Name = "TBFacFecha"
        Me.TBFacFecha.Size = New System.Drawing.Size(353, 22)
        Me.TBFacFecha.TabIndex = 5
        '
        'TBfacID
        '
        Me.TBfacID.Location = New System.Drawing.Point(141, 23)
        Me.TBfacID.Margin = New System.Windows.Forms.Padding(4)
        Me.TBfacID.Name = "TBfacID"
        Me.TBfacID.Size = New System.Drawing.Size(353, 22)
        Me.TBfacID.TabIndex = 1
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
        'TBfacLocal
        '
        Me.TBfacLocal.Location = New System.Drawing.Point(141, 54)
        Me.TBfacLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.TBfacLocal.Name = "TBfacLocal"
        Me.TBfacLocal.Size = New System.Drawing.Size(353, 22)
        Me.TBfacLocal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Local"
        '
        'btnFacBorrar
        '
        Me.btnFacBorrar.Location = New System.Drawing.Point(116, 218)
        Me.btnFacBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFacBorrar.Name = "btnFacBorrar"
        Me.btnFacBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnFacBorrar.TabIndex = 9
        Me.btnFacBorrar.Text = "Borrar"
        Me.btnFacBorrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ID Cliente"
        '
        'btnFacGuardar
        '
        Me.btnFacGuardar.Location = New System.Drawing.Point(8, 218)
        Me.btnFacGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFacGuardar.Name = "btnFacGuardar"
        Me.btnFacGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnFacGuardar.TabIndex = 8
        Me.btnFacGuardar.Text = "Guardar"
        Me.btnFacGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total Facturado"
        '
        'TBfacIdClient
        '
        Me.TBfacIdClient.Location = New System.Drawing.Point(141, 86)
        Me.TBfacIdClient.Margin = New System.Windows.Forms.Padding(4)
        Me.TBfacIdClient.Name = "TBfacIdClient"
        Me.TBfacIdClient.Size = New System.Drawing.Size(353, 22)
        Me.TBfacIdClient.TabIndex = 3
        '
        'tbFacClientName
        '
        Me.tbFacClientName.Location = New System.Drawing.Point(141, 118)
        Me.tbFacClientName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFacClientName.Name = "tbFacClientName"
        Me.tbFacClientName.Size = New System.Drawing.Size(353, 22)
        Me.tbFacClientName.TabIndex = 4
        '
        'DGVdetalle
        '
        Me.DGVdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdetalle.Location = New System.Drawing.Point(15, 281)
        Me.DGVdetalle.Name = "DGVdetalle"
        Me.DGVdetalle.RowTemplate.Height = 24
        Me.DGVdetalle.Size = New System.Drawing.Size(990, 260)
        Me.DGVdetalle.TabIndex = 23
        '
        'FrmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVdetalle)
        Me.Controls.Add(Me.DGVfacturas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVfacturas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBFacFecha As TextBox
    Friend WithEvents TBfacID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBfacLocal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFacBorrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFacGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBfacIdClient As TextBox
    Friend WithEvents tbFacClientName As TextBox
    Friend WithEvents tbFacTotal As TextBox
    Friend WithEvents btnFactCerrar As Button
    Friend WithEvents DGVdetalle As DataGridView
End Class
