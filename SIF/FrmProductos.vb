Public Class FrmProductos
    Dim ca As New Logica.Categoria
    Dim un As New Logica.Unidad
    Dim es As New Logica.Estado
    Dim pr As New Logica.Producto

    Private Sub BtnProdCerrar_Click(sender As Object, e As EventArgs) Handles btnProdCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbCategoria.DataSource = ca.ConsultaCategorias
        cbCategoria.DisplayMember = "CAT_DESCRIPCION"
        cbCategoria.ValueMember = "CAT_IDCATEGORIA"

        cbUnidad.DataSource = un.ConsultaUnidades
        cbUnidad.DisplayMember = "UNI_DESCRIPCION"
        cbUnidad.ValueMember = "UNI_IDUNIDAD"

        cbEstado.DataSource = es.ConsultaEstados
        cbEstado.DisplayMember = "EST_DESCRIPCION"
        cbEstado.ValueMember = "EST_IDESTADO"

        DGVproductos.DataSource = pr.ConsultaProductos
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Try
            If pr.IngresarProducto(tbId.Text, cbCategoria.SelectedValue, cbUnidad.SelectedValue, cbEstado.SelectedValue, tbNombre.Text, tbCantidad.Text, tbPrecio.Text) > 0 Then
                MsgBox("Registrado correctamente")
            End If
            DGVproductos.DataSource = pr.ConsultaProductos
            DGVproductos.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class