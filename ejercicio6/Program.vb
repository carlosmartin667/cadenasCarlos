'Ejercicio 6:
'A partir de un texto:
'Mostrarlo en pantalla.
'Encontrar y colorear todas las vocales en rojo.


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

                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White


            ElseIf letra = "e" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White

            ElseIf letra = "i" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White

            ElseIf letra = "o" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White

            ElseIf letra = "u" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White


            ElseIf letra = "A" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White

            ElseIf letra = "E" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White

            ElseIf letra = "I" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White
            ElseIf letra = "O" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White
            ElseIf letra = "U" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(letra)
                Console.ForegroundColor = ConsoleColor.White
            Else
                Console.Write(letra)
            End If




        Next

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
    End Sub
End Module
