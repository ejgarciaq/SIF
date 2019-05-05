Public Class Empresa
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Se utiliza para validar si un Empresa existe utilizando el nombre y la contraseña
    Function VerificarEmpresa(Empresa As String)
        sql = "SELECT * FROM local WHERE EMP_IDEMPRESA = '" & Empresa & "'"
        If (con.VerificarDatos(sql)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Solicita los Empresas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaLocal()
        sql = "SELECT *  FROM local"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Empresa nuevo con los datos respectivos
    Function IngresarEmpresa(id As String, rol As String, nombre As String, intentos As String, pass As String, cambio As Boolean)
        sql = "INSERT INTO local VALUES ('" & id & "','" & rol & "','" & nombre & "','" & intentos & "','" & pass & "'," & cambio & ")"
        Return con.IngresarDatos(sql)
    End Function
End Class
