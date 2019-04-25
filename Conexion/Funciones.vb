Imports MySql.Data.MySqlClient
Public Class Funciones
    Dim con As New Conexion

    Function ObtenerDatos(conString As String)
        con.Conectar()
        Dim com As New MySqlCommand(conString, con.Conex)
        con.Desconectar()
        Return False
    End Function

    Function IngresarDatos(conString As String)
        con.Conectar()
        Dim com As New MySqlCommand(conString, con.Conex)
        con.Desconectar()
        Return False
    End Function

    Function VerificarDatos(conString As String)
        con.Conectar()
        Dim cmd As New MySqlCommand(conString, con.Conex)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        Try
            If dr.Read = False Then
                Return False
            Else
                Return True
            End If
            con.Desconectar()
        Catch
            Return False
            con.Desconectar()
        End Try
    End Function
End Class
