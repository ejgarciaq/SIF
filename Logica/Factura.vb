Public Class Factura
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Verifica si la factura existe'
    Function VerificarFactura(id As String)
        sql = "select * from factura where FAC_IDFACTURA = " + id + ";"
        If (con.VerificarDatos(sql)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Modifica el precio cada vez que se ingresa un nuevo detalle'
    Function ModificarPrecio(id As String, precio As String)
        sql = "UPDATE factura SET FAC_TOTAL = " + precio + " WHERE FAC_IDFACTURA = " + id
        Return con.IngresarDatos(sql)
    End Function

    'Solicita los Facturas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaFacturas()
        sql = "SELECT * FROM factura"
        Return con.ObtenerDatos(sql)
    End Function

    'Solicita los Facturas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaFactura(id As String)
        sql = "SELECT * FROM factura WHERE FAC_IDFACTURA = " + id + ";"
        Return con.ObtenerDato(sql)
    End Function

    'Ingresa una factura nueva con los datos respectivos
    Function IngresarFactura(id As String, local As String, cliente As String, usuario As String, fecha As String)
        sql = "INSERT INTO `sif_db`.`factura` (`FAC_IDFACTURA`, `EMP_IDEMPRESA`, `CLI_IDPERSONA`, `USU_IDPERSONA`, `FAC_FECHA`, `FAC_TOTAL`, `FAC_ACTIVA`) VALUES (" + id + ", " + local + ", " + cliente + ", " + usuario + ", '" + fecha + "', 0, true);"
        Return con.IngresarDatos(sql)
    End Function
End Class
