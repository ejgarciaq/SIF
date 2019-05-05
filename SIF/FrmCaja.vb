Public Class Caja
    Dim us As New Logica.Usuario
    Dim em As New Logica.Local
    Dim cl As New Logica.Cliente
    Dim pr As New Logica.Producto
    Dim fc As New Logica.Factura

    Private Sub FrmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbUsuario.DataSource = us.ConsultaUsuarios
        cbUsuario.ValueMember = "USU_IDPERSONA"
        cbUsuario.DisplayMember = "USU_IDPERSONA"

        cbEmpresa.DataSource = em.ConsultaLocales
        cbEmpresa.ValueMember = "EMP_IDEMPRESA"
        cbEmpresa.DisplayMember = "EMP_IDEMPRESA"

        cbCliente.DataSource = cl.ConsultaClientes
        cbCliente.ValueMember = "CLI_IDPERSONA"
        cbCliente.DisplayMember = "CLI_IDPERSONA"

        lbProducto.DataSource = pr.ConsultaProductos
    End Sub

    Private Sub BtnCajaCerrar_Click(sender As Object, e As EventArgs) Handles btnCajaCerrar.Click
        Me.Close()
    End Sub
End Class