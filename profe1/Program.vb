
Module Module1

    Sub Main()
        '1 A partir de una cadena de texto:
        Dim texto As String
        texto = "La tecnología 5G se muestra al mundo como uno de los pilares del futuro más próximo. Los smartphones de los años venideros tendrán como base la quinta generación de cobertura, y muchas son las marcas que ya han apostado por este tipo de soportes. Xiaomi, Samsung, Huawei, LG… Los fabricantes ya están trabajando en terminales con tecnología 5G integrada en sus procesadores, el único problema es que los países todavía no están preparados para recibir estas novedades."

        '2 Mostrar en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3 Solicitar al usuario ingrese una palabra a buscar en el texto.
        Dim palabra As String
        Dim encontro As Integer

        Do While True
            Console.Write("Ingrese palabra a buscar: ")
            palabra = Console.ReadLine
            Console.WriteLine()

            If palabra = "" Then Exit Do

            encontro = texto.IndexOf(palabra)

            '4 Si la palabra se encuentra mostrar el texto con la palabra coloreada en rojo sino mostrar el cartel no La palabra no se encuentra.
            If encontro = -1 Then
                Console.WriteLine("La palabra " & palabra & " no se encontró.")
            Else
                Console.Write(texto.Substring(0, encontro))

                Console.BackgroundColor = ConsoleColor.Yellow
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(palabra)
                Console.BackgroundColor = ConsoleColor.Black
                Console.ForegroundColor = ConsoleColor.White

                Console.WriteLine(texto.Substring(encontro + palabra.Length))


            End If

            Console.WriteLine()
        Loop

    End Sub

End Module
