Public Class Roles
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los roles existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaRoles()
        sql = "select ROL_IDROL,ROL_DESCRIPCION,ROL_ACTIVO from rol;"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un rol nuevo con los datos respectivos
    Function IngresarRol(id As String, rolDes As String)
        sql = "INSERT INTO `sif_db`.`rol` (`ROL_IDROL`, `ROL_DESCRIPCION`, `ROL_ACTIVO`) VALUES (" + id + ", '" + rolDes + "', true);"
        con.IngresarDatos(sql)
        Return con.IngresarDatos(sql)
    End Function

End Class
