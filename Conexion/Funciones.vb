Imports MySql.Data.MySqlClient
Public Class Funciones
    Dim con As New Conexion

    Function ObtenerDatos(conString As String)
        con.Conectar()
        Dim da As New MySqlDataAdapter(conString, con.Conex)
        Dim dt As New DataTable
        da.Fill(dt)
        con.Desconectar()
        Return dt
    End Function

    Function IngresarDatos(conString As String)
        con.Conectar()
        Dim com As New MySqlCommand(conString, con.Conex)
        Dim rows As Integer
        Try
            rows = com.ExecuteNonQuery
            con.Desconectar()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            con.Desconectar()
        End Try
        Return rows
    End Function

    Function VerificarDatos(conString As String)
        Dim cmd As New MySqlCommand(conString, con.Conex)
        Try
            con.Conectar()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
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
