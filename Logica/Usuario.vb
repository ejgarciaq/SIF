Public Class Usuario
    Dim con As New Conexion.Funciones
    Dim sql As String
    Dim sql2 As String

    'Se utiliza para validar si un usuario existe utilizando el nombre y la contraseña
    Function VerificarUsuario(usuario As String, contrasena As String)
        sql = "select * from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t1.USU_PASSWORD = '" + contrasena + "' and t2.ROL_DESCRIPCION = 'Administrador';"
        sql2 = "select * from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t1.USU_PASSWORD = '" + contrasena + "' and t2.ROL_DESCRIPCION = 'Vendedor';"
        If (con.VerificarDatos(sql)) Then
            Return 1
        ElseIf (con.VerificarDatos(sql2)) Then
            Return 2
        Else
            Return 3
        End If
    End Function

    'Solicita los usuarios existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaUsuario()
        sql = "SELECT *  FROM usuario"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un usuario nuevo con los datos respectivos
    Function IngresarUsuario(id As String, rol As String, nombre As String, intentos As String, pass As String, cambio As Boolean)
        sql = "INSERT INTO usuario VALUES ('" & id & "','" & rol & "','" & nombre & "','" & intentos & "','" & pass & "'," & cambio & ")"
        Return con.IngresarDatos(sql)
    End Function

    'Se asegura que la contraseña sea valida(mas de 8 caracteres y no este vacia)
    Function IsPasswordValid(password As String) As Boolean
        ' Si es Nothing no es válida.
        If (password Is Nothing) Then
            MsgBox("Debe escribir la contraseña.")
            Return False
        End If

        ' Si su longitud es menor de 8 caracteres, no es válida.
        If (password.Length < 8) Then
            MsgBox("La contraseña debe contener 8 dígitos.")
            Return False
        End If

        Dim existeNumero As Boolean
        Dim existeLetraMayuscula As Boolean
        Dim caracteresEspeciales As Boolean
        Dim caracteres As String = "@!/*-+.,%$#?¿"

        ' Ya solo queda verificar si al menos hay
        ' un número y una letra en mayúscula.

        'Verifica que la contraseña contenga aunque sea una letra mayuscula,un numero y un caracter especial.
        For Each c As Char In password

            For Each ch As Char In caracteres
                If (c = ch) Then
                    caracteresEspeciales = True
                    Exit For
                End If
            Next

            If (Char.IsDigit(c)) Then
                    existeNumero = True
                    Continue For
                End If

                If (c = c.ToString().ToUpper()) Then
                    existeLetraMayuscula = True
                End If


            Next
        If (existeNumero) And (existeLetraMayuscula) And (caracteresEspeciales) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
