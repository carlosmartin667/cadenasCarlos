
'Ejercicio 2:
'A partir de un texto:
'Mostrarlo en pantalla.
'Pasar el texto a un vector.
'Recorrer el vector.
'Determinar si la palabra o elemento comienza en mayúscula.
'Si empieza con mayúscula imprimir en color rojo sino imprimir en blanco, deben formar un párrafo.


Module Program
    Sub Main(args As String())
        'Console.BackgroundColor = ConsoleColor.White
        'Console.ForegroundColor = ConsoleColor.Red
        Console.Clear()
        Dim cadena, subcad, palabra, letra As String
        Dim contador = 0
        Dim largo = 0
        cadena = "El Índice TIOBE es un índice elaborado por una empresa de software holandesa que se especializa en la evaluación y seguimiento de la calidad de los programas informáticos. Actualmente, la empresa revisa en tiempo real más de 300 millones de códigos de diversos programas informáticos por día actualizando mes a mes su índice."






        For y = 0 To cadena.Length - 1
            letra = cadena.Substring(y, 1)

            If letra >= "A" And letra <= "Z" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White
            Else
                Console.Write(letra)

            End If

        Next

    End Sub
End Module