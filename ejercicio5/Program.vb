'Ejercicio 5:
'A partir de un texto:
'Mostrarlo en pantalla.
'Encontrar las vocales y reemplazarlas seg�n la siguiente lista (a - 1, e - 2, i - 3, o - 4, u - 5)
'Mostrar como queda la nueva cadena o la cadena original modificada.


Imports System

Module Program
    Sub Main(args As String())
        Dim cadena, subcad, palabra, letra As String
        Dim contador = 0
        Dim largo = 0
        cadena = "El �ndice TIOBE es un �ndice elaborado por una empresa de software holandesa que se especializa en la evaluaci�n y seguimiento de la calidad de los programas inform�ticos. Actualmente, la empresa revisa en tiempo real m�s de 300 millones de c�digos de diversos programas inform�ticos por d�a actualizando mes a mes su �ndice."

        Console.WriteLine(cadena)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        For x = 0 To cadena.Length - 1
            letra = cadena.Substring(x, 1)

            If letra = "a" Then
                letra = 1
            End If
            If letra = "e" Then
                letra = 2
            End If
            If letra = "i" Then
                letra = 3
            End If
            If letra = "o" Then
                letra = 4
            End If
            If letra = "u" Then
                letra = 5
            End If







            If letra = "A" Then
                letra = 6
            End If
            If letra = "E" Then
                letra = 7
            End If
            If letra = "I" Then
                letra = 8
            End If
            If letra = "O" Then
                letra = 9
            End If
            If letra = "U" Then
                letra = "#"
            End If


            Console.Write(letra)
        Next

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

    End Sub
End Module
