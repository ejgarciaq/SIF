Public Class FormaPago
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los roles existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaFormaPagos()
        sql = "select * from `sif_db`.`formapago`;"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un rol nuevo con los datos respectivos
    Function IngresarFormaPago(id As String, Des As String)
        sql = "INSERT INTO `sif_db`.`formapago` VALUES (" + id + ", '" + Des + "', true);"
        con.IngresarDatos(sql)
        Return con.IngresarDatos(sql)
    End Function

End Class
