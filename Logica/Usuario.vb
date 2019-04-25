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

    Function ConsultaUsuario()
        sql = "SELECT *  FROM usuarios_table"
        Return con.ObtenerDatos(sql)
    End Function

    Function IngresarUsuario(id As String, rol As String, nombre As String, intentos As String, pass As String, cambio As Boolean)
        Dim act As Byte
        If cambio Then
            act = 0
        Else
            act = 1
        End If
        sql = "INSERT INTO usuarios_table VALUES ('" & id & "','" & rol & "','" & nombre & "','" & intentos & "','" & pass & "','" & act & "')"
        Return con.IngresarDatos(sql)
    End Function

    Function IsPasswordValid(password As String) As Boolean
        ' Si es Nothing no es válida.
        If (password Is Nothing) Then Return False

        ' Si su longitud es menor de 8 caracteres, no es válida.
        If (password.Length < 8) Then Return False

        Dim existeNumero As Boolean
        Dim existeLetraMayuscula As Boolean
        'Dim caracteresEspeciales As Boolean
        'Dim caracteres As String = "@!/*-+.,%$#?¿"

        ' Ya solo queda verificar si al menos hay
        ' un número y una letra en mayúscula.
        '
        For Each c As Char In password

            If (Char.IsDigit(c)) Then
                existeNumero = True
                Continue For
            End If

            If (c = c.ToString().ToUpper()) Then
                existeLetraMayuscula = True
            End If


        Next
        '( And (caracteresEspeciales)
        Return (existeNumero) And (existeLetraMayuscula)
    End Function
End Class
