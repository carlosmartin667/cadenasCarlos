'Ejercicio 1:
'1.	A partir de una cadena de texto:
'2.	Mostrar en pantalla.
'3.	Solicitar al usuario ingrese una palabra a buscar en el texto.
'4.	Si la palabra se encuentra mostrar el texto con la palabra coloreada en rojo sino mostrar el cartel no La palabra no se encuentra.

Module Module1

    Sub Main()
        Dim texto, palabra, V() As String
        Dim X, Pos, Continuar As Integer

        '1. Texto a analizar
        texto = "Hola yo me llamo Mono.  chau Mono"

        '2. Mostrar texto por pantalla
        Console.WriteLine(texto)
        Console.WriteLine()

        '3.Solicitar al usuario que ingrese una palabra a buscar en el texto
        Console.Write("INGRESE PALABRA A BUSCAR EN EL TEXTO: ")
        palabra = Console.ReadLine()

        '4. Si la palabra se encuentra mostrar el texto con la palabra coloreada en rojo sino mostrar el cartel 
        '   no La palabra no se encuentra.
        If texto.Contains(palabra) Then
            Pos = texto.IndexOf(palabra)
            Console.Write(texto.Substring(0, Pos))
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(texto.Substring(Pos, palabra.Length))
            Console.ForegroundColor = ConsoleColor.Gray
            Console.Write(texto.Substring(Pos + palabra.Length))
        Else
            Console.WriteLine()
            Console.WriteLine("LA PALABRA NO SE ENCUENTRA EN EL TEXTO")
        End If
        Console.ReadLine()
    End Sub

End Module