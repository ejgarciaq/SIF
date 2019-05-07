<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBusuario = New System.Windows.Forms.TextBox()
        Me.TBclave = New System.Windows.Forms.TextBox()
        Me.BTIngresar = New System.Windows.Forms.Button()
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.BTNcerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave"
        '
        'TBusuario
        '
        Me.TBusuario.Location = New System.Drawing.Point(101, 20)
        Me.TBusuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBusuario.Name = "TBusuario"
        Me.TBusuario.Size = New System.Drawing.Size(227, 22)
        Me.TBusuario.TabIndex = 2
        '
        'TBclave
        '
        Me.TBclave.Location = New System.Drawing.Point(101, 55)
        Me.TBclave.Margin = New System.Windows.Forms.Padding(4)
        Me.TBclave.Name = "TBclave"
        Me.TBclave.Size = New System.Drawing.Size(227, 22)
        Me.TBclave.TabIndex = 3
        Me.TBclave.UseSystemPasswordChar = True
        '
        'BTIngresar
        '
        Me.BTIngresar.Location = New System.Drawing.Point(48, 121)
        Me.BTIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTIngresar.Name = "BTIngresar"
        Me.BTIngresar.Size = New System.Drawing.Size(100, 28)
        Me.BTIngresar.TabIndex = 4
        Me.BTIngresar.Text = "Ingresar"
        Me.BTIngresar.UseVisualStyleBackColor = True
        '
        'CB1
        '
        Me.CB1.AutoSize = True
        Me.CB1.Location = New System.Drawing.Point(101, 89)
        Me.CB1.Margin = New System.Windows.Forms.Padding(4)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(117, 21)
        Me.CB1.TabIndex = 5
        Me.CB1.Text = "Mostrar Clave"
        Me.CB1.UseVisualStyleBackColor = True
        '
        'BTNcerrar
        '
        Me.BTNcerrar.Location = New System.Drawing.Point(188, 121)
        Me.BTNcerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(100, 28)
        Me.BTNcerrar.TabIndex = 6
        Me.BTNcerrar.Text = "Cerrar"
        Me.BTNcerrar.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNcerrar)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.BTIngresar)
        Me.Controls.Add(Me.TBclave)
        Me.Controls.Add(Me.TBusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Inventario y Facturación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBusuario As TextBox
    Friend WithEvents TBclave As TextBox
    Friend WithEvents BTIngresar As Button
    Friend WithEvents CB1 As CheckBox
    Friend WithEvents BTNcerrar As Button
End Class
