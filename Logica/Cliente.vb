Public Class Cliente
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los Clientes existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaClientes()
        sql = "SELECT * FROM cliente"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Cliente nuevo con los datos respectivos
    Function IngresarCliente(id As String, nombre As String, apellido1 As String, apellido2 As String)
        sql = "INSERT INTO `sif_db`.`persona` VALUES (" + id + ", '" + nombre + "', '" + apellido1 + "', '" + apellido2 + "', true);"
        con.IngresarDatos(sql)
        sql = "INSERT INTO `sif_db`.`cliente` VALUES (" + id + ", 0, true);"
        Return con.IngresarDatos(sql)
    End Function
End Class
