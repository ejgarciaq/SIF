﻿Public Class Categoria
    Dim con As New Conexion.Funciones
    Dim sql As String

    Function ConsultaCategoria()
        sql = "select * from categoria;"
        Return con.ObtenerDatos(sql)
    End Function

End Class
