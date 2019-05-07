Public Class Detalle
    Dim con As New Conexion.Funciones
    Dim sql As String

    'Solicita los Facturas existentes y se obtiene una tabla(DataTable) para mostrar
    Function ConsultaDetalle(id As String)
        sql = "select * from factura t1 RIGHT join detalle t2 on t1.FAC_IDFACTURA = t2.FAC_IDFACTURA where t1.FAC_IDFACTURA = " + id
        Return con.ObtenerDatos(sql)
    End Function

    'Ingresa una factura nueva con los datos respectivos
    Function IngresarDetalle(id As String, factura As String, producto As String, cantidad As String, precio As String)
        sql = "INSERT INTO `sif_db`.`detalle` VALUES (" + id + ", " + factura + ", " + producto + ", " + cantidad + ", '" + precio + "');"
        Return con.IngresarDatos(sql)
    End Function
End Class
