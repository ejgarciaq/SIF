Public Class Rol
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los usuarios existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaRol()
        sql = "select * from rol;"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un usuario nuevo con los datos respectivos
    Function IngresarRol(id As String, descripcion As String)
        sql = "INSERT INTO `sif_db`.`rol` (`ROL_IDROL`,`ROL_DESCRIPCION`,`ROL_ACTIVO`) VALUES (" + id + ", '" + descripcion + "', true);"
        con.IngresarDatos(sql)
        Return con.IngresarDatos(sql)
    End Function
End Class
