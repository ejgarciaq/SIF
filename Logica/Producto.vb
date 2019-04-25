Public Class Producto
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Se utiliza para validar si un Producto existe utilizando el nombre y la contraseña
    Function VerificarProducto(Producto As String)
        sql = "SELECT * FROM Productos_table WHERE PRO_IDPRODUCTO = '" & Producto & "'"
        If (con.VerificarDatos(sql)) Then
            Return True
        Else
            Return False
        End If
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
