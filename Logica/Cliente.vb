﻿Public Class Cliente
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Se utiliza para validar si un Cliente existe utilizando el nombre y la contraseña
    Function VerificarCliente(Cliente As String)
        sql = "SELECT * FROM Clientes_table WHERE CLI_IDCLIENTE = '" & Cliente & "'"
        If (con.VerificarDatos(sql)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Solicita los Clientes existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaCliente()
        sql = "SELECT *  FROM Clientes_table"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Cliente nuevo con los datos respectivos
    Function IngresarCliente(id As String, rol As String, nombre As String, intentos As String, pass As String, cambio As Boolean)
        sql = "INSERT INTO Clientes_table VALUES ('" & id & "','" & rol & "','" & nombre & "','" & intentos & "','" & pass & "'," & cambio & ")"
        Return con.IngresarDatos(sql)
    End Function
End Class