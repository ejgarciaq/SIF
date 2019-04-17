Imports MySql.Data
Imports MySql.Data.MySqlClient

Module ModuleCNN
    Public cnn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adaptador As New MySqlDataAdapter
    Public datos As New DataSet

    Public Function Conectar()
        Try
            cnn.ConnectionString = "Server=localhost;Database=sif_db;Uid=root;Pwd=T4rtaro1981;"
            cnn.Open()
            'MsgBox("La conexion se realizo correctamente", vbInformation)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub CerraConexion()
        Try
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
