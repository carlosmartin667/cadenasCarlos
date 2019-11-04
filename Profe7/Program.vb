Module Module1

    Sub Main()
        '1 A partir de un texto:
        Dim texto As String
        texto = "La tecnología 5G se muestra al mundo como uno de los pilares del futuro más próximo. Los smartphones de los años venideros tendrán como base la quinta generación de cobertura, y muchas son las marcas que ya han apostado por este tipo de soportes. Xiaomi, Samsung, Huawei, LG… Los fabricantes ya están trabajando en terminales con tecnología 5G integrada en sus procesadores, el único problema es que los países todavía no están preparados para recibir estas novedades."

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
        'una última fila y debo imprimir esa fracción.
        If filas * 40 < texto.Length Then
            Console.WriteLine(texto.Substring(c))
        End If

        Console.ReadLine()

    End Sub

End Module
