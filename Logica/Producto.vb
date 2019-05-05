Public Class Producto
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los usuarios existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaProductos()
        sql = "select PRO_NOMBRE from producto;"
        Return con.ObtenerDatos(sql)
    End Function

    Function ConsultaProducto(id As Integer)
        sql = "select PRO_IDPRODUCTO, PRO_NOMBRE, PRO_CANTIDAD from producto where PRO_IDPRODUCTO = '" + id + "';"
        Return con.ObtenerDato(sql)

    End Function

    'Solicita los Productos existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaProducto()
        sql = "SELECT *  FROM Productos_table"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Producto nuevo con los datos respectivos
    Function IngresarProducto(id As String, rol As String, nombre As String, intentos As String, pass As String, cambio As Boolean)
        sql = "INSERT INTO Productos_table VALUES ('" & id & "','" & rol & "','" & nombre & "','" & intentos & "','" & pass & "'," & cambio & ")"
        Return con.IngresarDatos(sql)
    End Function
End Class
