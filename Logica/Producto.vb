Public Class Producto
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los usuarios existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaProductos()
        sql = "select PRO_NOMBRE from producto;"
        Return con.ObtenerDatos(sql)
    End Function

    'Solicita los Productos existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaProducto(id As String)
        sql = "SELECT *  FROM Producto where PRO_IDPRODUCTO = " + id
        Return con.ObtenerDatos(sql)
    End Function

    'Solicita los Productos existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaProductoCompleta()
        sql = "SELECT *  FROM Producto"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Producto nuevo con los datos respectivos
    Function IngresarProducto(id As String, categoria As String, unidad As String, estado As String, nombre As String, cantidad As Integer, precio As Double)
        sql = "INSERT INTO `sif_db`.`producto` (`PRO_IDPRODUCTO`, `PRO_IDCATEGORIA`, `PRO_IDUNIDAD`, `PRO_IDESTADO`, `PRO_NOMBRE`, `PRO_CANTIDAD`, `PRO_PRECIO`, `PRO_ACTIVO`) VALUES (" + id + "," + categoria + "," + unidad + "," + estado + "," + nombre + "," + cantidad + "," + precio + "," + True + ");"
        Return con.IngresarDatos(sql)
    End Function
End Class
