Module Module1

    Sub Main()
        '1 A partir de un texto:
        Dim texto As String
        texto = "La tecnolog�a 5G se muestra al mundo como uno de los pilares del futuro m�s pr�ximo. Los smartphones de los a�os venideros tendr�n como base la quinta generaci�n de cobertura, y muchas son las marcas que ya han apostado por este tipo de soportes. Xiaomi, Samsung, Huawei, LG� Los fabricantes ya est�n trabajando en terminales con tecnolog�a 5G integrada en sus procesadores, el �nico problema es que los pa�ses todav�a no est�n preparados para recibir estas novedades."

        '2 Mostrarlo en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3 Imprimir el texto en pantalla de 40 columnas y la cantidad de filas necesarias.
        Dim f, c, filas As Integer
        'Calculo cuantas filas completas necesito para imprimir.
        'Por eso tomo la parte entera del resultado.
        filas = Int(texto.Length / 40)

        'con f voy imprimiendo las filas completas.
        For f = 1 To filas
            Console.WriteLine(texto.Substring(c, 40))
            c = c + 40
        Next

        'Si la variable fila por 40 me da menos que que la longitud total
        'entonces me queda una parte fraccionaria, es decir un tramo de
        'una �ltima fila y debo imprimir esa fracci�n.
        If filas * 40 < texto.Length Then
            Console.WriteLine(texto.Substring(c))
        End If

        Console.ReadLine()

    End Sub

End Module
