Module OtrasFunciones
    Function IsPasswordValid(password As String) As Boolean

        ' Si es Nothing no es válida.
        If (password Is Nothing) Then Return False

        ' Si su longitud es menor de 8 caracteres, no es válida.
        If (password.Length < 8) Then Return False

        Dim existeNumero As Boolean
        Dim existeLetraMayuscula As Boolean
        'Dim caracteresEspeciales As Boolean
        'Dim caracteres As String = "@!/*-+.,%$#?¿"

        ' Ya solo queda verificar si al menos hay
        ' un número y una letra en mayúscula.
        '
        For Each c As Char In password

            If (Char.IsDigit(c)) Then
                existeNumero = True
                Continue For
            End If

            If (c = c.ToString().ToUpper()) Then
                existeLetraMayuscula = True
            End If


        Next
        '( And (caracteresEspeciales)
        Return (existeNumero) And (existeLetraMayuscula))

    End Function
End Module
