Public Class Factura
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Se utiliza para validar si un Factura existe utilizando el nombre y la contraseña
    Function VerificarFactura(Factura As String)
        sql = "SELECT * FROM Facturas_table WHERE FAC_IDFACTURA = '" & Factura & "'"
        If (con.VerificarDatos(sql)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Solicita los Facturas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaFactura()
        sql = "SELECT *  FROM Facturas_table"
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa un Factura nuevo con los datos respectivos
    Function IngresarFactura(id As String, rol As String, nombre As String, intentos As String, pass As String, cambio As Boolean)
        sql = "INSERT INTO Facturas_table VALUES ('" & id & "','" & rol & "','" & nombre & "','" & intentos & "','" & pass & "'," & cambio & ")"
        Return con.IngresarDatos(sql)
    End Function
End Class
