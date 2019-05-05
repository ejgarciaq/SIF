Imports MySql.Data.MySqlClient
Public Class Conexion

    Dim con As New MySqlConnection("server=localhost;user id=root;password=T4rtaro1981;database=sif_db")
    Sub Conectar()
        Try
            con.Open()
        Catch ex As MySqlException
            con.Close()
        End Try
    End Sub

    Sub Desconectar()
        Try
            con.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Property Conex As MySqlConnection
        Get
            Return con
        End Get
        Set(value As MySqlConnection)
            con = value
        End Set
    End Property
End Class
