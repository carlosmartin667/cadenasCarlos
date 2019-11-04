Module Module1

    Sub Main()
        '1 A partir de un texto:
        Dim texto As String
        texto = "La tecnología 5G se muestra al mundo como uno de los pilares del futuro más próximo. Los smartphones de los años venideros tendrán como base la quinta generación de cobertura, y muchas son las marcas que ya han apostado por este tipo de soportes. Xiaomi, Samsung, Huawei, LG… Los fabricantes ya están trabajando en terminales con tecnología 5G integrada en sus procesadores, el único problema es que los países todavía no están preparados para recibir estas novedades."

        '2 Mostrarlo en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3 Encontrar cada unos de los artículos de la lista (el, la, los, las, un, una, unos, unas) e imprimir el artículo y la posición dentro de la cadena de cada aparición.
        Dim v() As String
        v = texto.Split(" ")

        '4 Contar y mostrar cuantos artículos de cada uno se encontraron.
        Dim x, c1, c2, c3, c4, c5, c6, c7, c8 As Integer
        For x = 0 To v.Length - 1
            'el
            If v(x) = "el" Then
                c1 = c1 + 1
            End If

            'la
            If v(x) = "la" Then
                c2 = c2 + 1
            End If

            'los
            If v(x) = "los" Then
                c3 = c3 + 1
            End If

            'las
            If v(x) = "las" Then
                c4 = c4 + 1
            End If

            'un
            If v(x) = "un" Then
                c5 = c5 + 1
            End If

            'una
            If v(x) = "una" Then
                c6 = c6 + 1
            End If

            'unos
            If v(x) = "unos" Then
                c7 = c7 + 1
            End If

            'unas
            If v(x) = "unas" Then
                c8 = c8 + 1
            End If

        Next
        '(el, la, los, las, un, una, unos, unas)
        Console.WriteLine("Total ""el"": " & CStr(c1))
        Console.WriteLine("Total ""la"": " & CStr(c2))
        Console.WriteLine("Total ""los"": " & CStr(c3))
        Console.WriteLine("Total ""las"": " & CStr(c4))
        Console.WriteLine("Total ""un"": " & CStr(c5))
        Console.WriteLine("Total ""una"": " & CStr(c6))
        Console.WriteLine("Total ""unos"": " & CStr(c7))
        Console.WriteLine("Total ""unas"": " & CStr(c8))


        Console.ReadLine()

    End Sub

End Module