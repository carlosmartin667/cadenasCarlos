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
        cadena = "El Índice TIOBE es un índice elaborado por una empresa de software holandesa que se especializa en la evaluación y seguimiento de la calidad de los programas informáticos. Actualmente, la empresa revisa en tiempo real más de 300 millones de códigos de diversos programas informáticos por día actualizando mes a mes su índice."

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
