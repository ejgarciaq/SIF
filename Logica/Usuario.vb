Public Class Usuario
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Se utiliza para validar si un usuario existe utilizando el nombre y la contraseña
    Function VerificarUsuario(usuario As String, contrasena As String)
        sql = "select t2.ROL_DESCRIPCION from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t1.USU_PASSWORD = '" + contrasena + "' and t2.ROL_DESCRIPCION = 'Administrador';"
        If (con.VerificarDatos(sql)) Then
            Return 1
        End If
        sql = "select t2.ROL_DESCRIPCION from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t1.USU_PASSWORD = '" + contrasena + "' and t2.ROL_DESCRIPCION = 'Vendedor';"
        If (con.VerificarDatos(sql)) Then
            Return 2
        Else
            Return 3
        End If
    End Function

    'Se utiliza para validar si un usuario existe utilizando el nombre y la contraseña
    Function VerificarUsuarios(usuario As String)
        sql = "select t2.ROL_DESCRIPCION from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t2.ROL_DESCRIPCION = 'Administrador';"
        If (con.VerificarDatos(sql)) Then
            Return 1
        End If
        sql = "select t2.ROL_DESCRIPCION from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t2.ROL_DESCRIPCION = 'Vendedor';"
        If (con.VerificarDatos(sql)) Then
            Return 2
        Else
            Return 3
        End If
    End Function

    'Se utiliza para validar si un usuario existe utilizando el nombre y la contraseña
    Function VerificarContrasena(usuario As String, contrasena As String)
        sql = "select t2.ROL_DESCRIPCION from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t1.USU_PASSWORD = '" + contrasena + "' and t2.ROL_DESCRIPCION = 'Administrador';"
        If (con.VerificarDatos(sql)) Then
            Return True
        End If
        sql = "select t2.ROL_DESCRIPCION from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL where t1.USU_USERNAME = '" + usuario + "' and t1.USU_PASSWORD = '" + contrasena + "' and t2.ROL_DESCRIPCION = 'Vendedor';"
        If (con.VerificarDatos(sql)) Then
            Return False
        End If
        Return False
    End Function

    Function BajarIntentos(usuario As String)
        sql = "select * from usuario where USU_USERNAME = '" + usuario + "';"
        Dim dt As DataTable = con.ObtenerDato(sql)
        If Convert.ToInt32(dt.Rows(0).Item(4).ToString) = 0 Then
            sql = "UPDATE usuario SET USU_INTENTOS = 3"
            con.IngresarDatos(sql)
            Return False
        Else
            Dim intentos = Convert.ToInt32(dt.Rows(0).Item(4).ToString) - 1
            sql = "UPDATE usuario SET USU_INTENTOS = " + intentos
            con.IngresarDatos(sql)
            Return True
        End If

    End Function

    'Solicita los usuarios existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaUsuarios()
        sql = "select USU_IDPERSONA,USU_USERNAME,USU_PASSWORD,t2.ROL_DESCRIPCION,USU_INTENTOS,USU_ACTIVO from usuario t1 join rol t2 on t1.ROL_IDROL = t2.ROL_IDROL;"
        Return con.ObtenerDatos(sql)
    End Function

    Function ConsultaUsuario(id As Integer)
        sql = "select PER_IDPERSONA, PER_NOMBRE, PER_APELLIDO1, PER_APELLIDO2, USU_USERNAME, USU_PASSWORD,t2.ROL_DESCRIPCION from persona t1 join usuario t2 on t1.PER_IDPERSONA = T2.PER_IDPERSONA join rol t3 on t2.ROL_IDROL = t3.ROL_IDROL WHERE T1.PER_IDPERSONA = '" + id + "';"
        Return con.ObtenerDato(sql)

    End Function

    'Ingresa un usuario nuevo con los datos respectivos
    Function IngresarUsuario(id As String, nombre As String, apellido1 As String, apellido2 As String, username As String, password As String, rol As String)
        sql = "INSERT INTO `sif_db`.`persona` VALUES (" + id + ", '" + nombre + "', '" + apellido1 + "', '" + apellido2 + "', true);"
        con.IngresarDatos(sql)
        sql = "INSERT INTO `sif_db`.`usuario` VALUES (" + id + ", " + rol + ", '" + username + "', '" + password + "', 3, true);"
        Return con.IngresarDatos(sql)
    End Function

    Function BorrarUsuario(id As String)
        sql = "DELETE FROM `sif_db`.`usuario` WHERE PER_IDPERSONA = " + id + " LIMIT 1"
        Return con.BorrarDatos(sql)
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

        Dim existeNumero As Boolean = False
        Dim existeLetraMayuscula As Boolean = False
        Dim caracteresEspeciales As Boolean = False
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
