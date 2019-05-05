Public Class FormaPago
    Dim con As New Conexion.Funciones
    Dim sql As String

    Function ConsultaFormaPago()
        sql = "select * from formapago;"
        Return con.ObtenerDatos(sql)
    End Function

End Class
