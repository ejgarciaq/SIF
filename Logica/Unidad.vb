﻿Public Class Unidad
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los roles existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaUnidad()
        sql = "select UNI_IDUNIDAD,UNI_DESCRIPCION,UNI_ACTIVO from unidad;"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un rol nuevo con los datos respectivos
    Function IngresarUnidad(id As String, rolDes As String, rol As Integer)

    End Function

End Class
