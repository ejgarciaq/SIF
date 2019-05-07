Public Class Unidad
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los roles existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaUnidades()
        sql = "select * from unidad;"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un rol nuevo con los datos respectivos
    Function IngresarUnidad(id As String, rolDes As String)
        sql = "INSERT INTO `sif_db`.`unidad` VALUES (" + id + ", '" + rolDes + "', true);"
        Return con.IngresarDatos(sql)
    End Function

End Class
