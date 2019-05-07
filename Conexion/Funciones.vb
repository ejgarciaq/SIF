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

    Function ObtenerDato(conString As String)
        con.Conectar()
        Dim da As New MySqlDataAdapter(conString, con.Conex)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            con.Desconectar()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            con.Desconectar()
        End Try
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
                con.Desconectar()
                Return False
            Else
                con.Desconectar()
                Return True
            End If
        Catch
            Return False
            con.Desconectar()
        End Try
    End Function

    Public Function BorrarDatos(sql As String) As Object
        Try
            con.Conectar()
            Dim com As New MySqlCommand(sql, con.Conex)
            Dim i As Integer
            i = com.ExecuteNonQuery
            con.Desconectar()
            Return i
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
