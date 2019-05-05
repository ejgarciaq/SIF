Public Class Empresa
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los Empresas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaEmpresas()
        sql = "SELECT *  FROM local"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Empresa nuevo con los datos respectivos
    Function IngresarEmpresa(id As String, nombre As String)
        sql = "INSERT INTO local VALUES ('" & id & "','" & nombre & "', true)"
        Return con.IngresarDatos(sql)
    End Function
End Class
