Public Class Estado
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los Estados existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaEstados()
        sql = "select * from estado;"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un estado nuevo con los datos respectivos
    Function IngresarEstado(id As String, EstDes As String, cbEstado As Boolean)
        sql = "INSERT INTO `sif_db`.`estado` (`EST_IDESTADO`, `EST_DESCRIPCION`, `EST_ACTIVO`) VALUES (" + id + ", '" + EstDes + "', true);"
        con.IngresarDatos(sql)
        Return con.IngresarDatos(sql)
    End Function

End Class
