Public Class Usuario
    Dim con As New Conexion.Funciones
    Dim sql As String

    Function VerificarUsuario(usuario As String, contrasena As String)
        sql = "SELECT * FROM usuarios_table WHERE USR_NOMBRE = '" & usuario & "' AND USR_PASSWORD = '" & contrasena & "'"
        If (con.VerificarDatos(sql)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
