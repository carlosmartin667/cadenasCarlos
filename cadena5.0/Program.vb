Module Module1

    Sub Main()

        Dim cad, v() As String

        cad = "Al presionar un mensaje dentro de una conversaci�n, ahora WhatsApp muestra la opci�n de responder citando ese mensaje. As�, el remitente puede especificar a qu� exactamente est� respondiendo. El nuevo bot�n b�sicamente es para citar y responder a un mensaje"

        Dim x As Integer

        Console.WriteLine(cad)
        Console.WriteLine()

        'Obtiene un vector con cadenas usando el separador coma (,).
        v = cad.Split(",")

        'Muestra cada elemento obtenido en v.
        For x = 0 To v.Length - 1

            Console.WriteLine(CStr(x) + " - " + v(x))

        Next

        Console.ReadLine()

    End Sub

End Module
