'Ejercicio 2:
'1.	A partir de un texto:
'2.	Mostrarlo en pantalla.
'3.	Pasar el texto a un vector.
'4.	Recorrer el vector.
'5.	Determinar si la palabra o elemento comienza en mayúscula.
'6.	Si empieza con mayúscula imprimir en color rojo sino imprimir en blanco, deben formar un párrafo.

Module Module1

    Sub Main()
        Dim texto, V(), letra, subTexto As String
        Dim X As Integer

        '1.	A partir de un texto:
        texto = "A la verga me vale verga. Lucho y Marquitos, me la sudAn."

        '2.	Mostrarlo en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3.	Pasar el texto a un vector.
        V = texto.Split(" ")

        '4.	Recorrer el vector.
        For X = 0 To V.Length - 1
            '5.	Determinar si la palabra o elemento comienza en mayúscula.
            V(X) = V(X).Substring(0)
            If V(X).Substring(0, 1) >= "A" And V(X).Substring(0, 1) <= "Z" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(V(X) & " ")
            Else
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(V(X) & " ")
            End If

        Next
        Console.WriteLine()
        Console.ReadLine()
    End Sub

End Module