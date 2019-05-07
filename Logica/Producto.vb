Public Class Producto
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los usuarios existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaProductos()
        sql = "select * from producto;"
        Return con.ObtenerDatos(sql)
    End Function

    'Modifica el precio cada vez que se ingresa un nuevo detalle'
    Function ModificarCantidad(id As String, cantidad As String)
        sql = "UPDATE producto SET PRO_CANTIDAD = " + cantidad + " WHERE PRO_IDPRODUCTO = " + id
        Return con.IngresarDatos(sql)
    End Function

    'Solicita los Productos existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaProducto(id As String)
        sql = "SELECT *  FROM Producto where PRO_IDPRODUCTO = " + id
        Return con.ObtenerDato(sql)
    End Function

    'Ingresa un Producto nuevo con los datos respectivos
    Function IngresarProducto(id As String, categoria As String, unidad As String, estado As String, nombre As String, cantidad As String, precio As String)
        sql = Convert.ToString("INSERT INTO `sif_db`.`producto` VALUES (" + id + ", " + categoria + "," + unidad + "," + estado + ",'" + nombre + "'," + cantidad + "," + precio + ", true);")
        Return con.IngresarDatos(sql)
    End Function
End Class
