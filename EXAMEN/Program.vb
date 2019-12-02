Module Module1
    'En base de un texto
    'Mostrarlo en color verde
    'sacarle los signos de puntuacion 
    'Los numeros remplazarlo por #
    'Buscar una palabra (texto en rojo, palara encontrada en blanco) si no la encuentra mensaje en azul de palabra no encontrada.
    'comprobar cuantas palabras hay repetidas texto mostrar palabras repetidas y cuantas veces
    Sub Main()
        Dim texto As String
        texto = "Quiere la boca exhausta vid, kiwi, piña y fugaz jamón. (42 letras) Fabio me exige, sin tapujos, que añada cerveza al whisky. (45 letras) Jovencillo emponzoñado de whisky, ¡qué figurota exhibe! (46 letras)"
        Console.WriteLine(texto)
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(texto)
        texto = texto.Replace(",", "")
        texto = texto.Replace(".", "")
        texto = texto.Replace("?", "")
        texto = texto.Replace("(", "")
        texto = texto.Replace(")", "")
        texto = texto.Replace("¿", "")
        texto = texto.Replace("1", "#")
        texto = texto.Replace("2", "#")
        texto = texto.Replace("3", "#")
        texto = texto.Replace("4", "#")
        texto = texto.Replace("5", "#")
        texto = texto.Replace("9", "#")
        texto = texto.Replace("8", "#")
        texto = texto.Replace("7", "#")
        texto = texto.Replace("6", "#")
        Console.WriteLine(texto)
        Console.ForegroundColor = ConsoleColor.Gray

        Dim Palabra, v() As String
        Dim x As Integer
        v = texto.Split(" ")
        Do While True
            Console.WriteLine()
            Console.Write("Ingrese palabra: ")
            Console.ForegroundColor = ConsoleColor.Red
            Palabra = Console.ReadLine()

            If Palabra = "" Then Exit Do

            If texto.Contains(Palabra) = True Then
                For x = 0 To v.Length - 1
                    If v(x) = Palabra Then
                        Console.ForegroundColor = ConsoleColor.White
                        Console.Write(v(x) & " ")
                        Console.ForegroundColor = ConsoleColor.Red
                    Else
                        Console.Write(v(x) & " ")
                    End If
                Next
                Console.WriteLine()
            Else
                Console.WriteLine()
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine("LA PALABRA NO SE ENCUENTRA")
                Console.ForegroundColor = ConsoleColor.White
            End If
        Loop

    End Sub

End Module