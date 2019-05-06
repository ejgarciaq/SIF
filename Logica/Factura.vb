Public Class Factura
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los Facturas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaFacturas()
        sql = "SELECT *  FROM Facturas_table"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa una factura nueva con los datos respectivos
    Function IngresarUsuario(id As String, nombre As String, apellido1 As String, apellido2 As String, username As String, password As String, rol As Integer)
        sql = "INSERT INTO `sif_db`.`factura` VALUES (" + id + ", " + rol + ", '" + username + "', '" + password + "', 3, true);"
        Return con.IngresarDatos(sql)
    End Function
End Class
