
'Ejercicio 2:
'A partir de un texto:
'Mostrarlo en pantalla.
'Pasar el texto a un vector.
'Recorrer el vector.
'Determinar si la palabra o elemento comienza en may�scula.
'Si empieza con may�scula imprimir en color rojo sino imprimir en blanco, deben formar un p�rrafo.


Module Program
    Sub Main(args As String())
        'Console.BackgroundColor = ConsoleColor.White
        'Console.ForegroundColor = ConsoleColor.Red
        Console.Clear()
        Dim cadena, subcad, palabra, letra As String
        Dim contador = 0
        Dim largo = 0
        cadena = "El �ndice TIOBE es un �ndice elaborado por una empresa de software holandesa que se especializa en la evaluaci�n y seguimiento de la calidad de los programas inform�ticos. Actualmente, la empresa revisa en tiempo real m�s de 300 millones de c�digos de diversos programas inform�ticos por d�a actualizando mes a mes su �ndice."






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