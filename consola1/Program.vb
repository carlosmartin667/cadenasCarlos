Module Module1

    Sub Main()
        Dim cadena, texto() As String
        cadena = "Podemos tener el tel�fono m�s sofisticado del mundo y el de �ltima generaci�n, pero si est� lleno de apps Android, especialmente redes sociales y juegos, la carga de bater�a no alcanzar� para todo el d�a de actividad."

        texto = cadena.Split(" ")

        Console.WriteLine(cadena)
        Console.WriteLine()
        Console.WriteLine()

        Dim x As Integer

        'muestra cad elemento del vector texto obtenidos a partir del String cadena
        For x = 0 To texto.Length - 1
            Console.WriteLine(CStr(x) + " - " + texto(x))
        Next

        Console.ReadLine()

    End Sub

End Module
