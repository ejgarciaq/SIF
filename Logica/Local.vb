Public Class Local
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los Empresas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaLocales()
        sql = "SELECT *  FROM local"
        Return con.ObtenerDatos(sql)
    End Function

    'Solicita los Empresas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaLocal(id As String)
        sql = "SELECT *  FROM local where LOC_IDLOCAL = " + id
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Empresa nuevo con los datos respectivos
    Function IngresarLocal(id As String, nombre As String)
        sql = "INSERT INTO local VALUES ('" & id & "','" & nombre & "', true)"
        Return con.IngresarDatos(sql)
    End Function
End Class
