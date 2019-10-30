'Ejercicio 7:
'A partir de un texto:
'Mostrarlo en pantalla.
'Imprimir el texto en pantalla de 40 columnas y la cantidad de filas necesarias.


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
        Dim v() As String
        v = cadena.Split(" ")
        Dim x As Integer
        For x = 0 To v.Length - 1
            contador = contador + 1
            If contador <= 4 Then
                If contador = 1 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write(v(x) + " ")
                End If
                If contador = 2 Then
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.Write(v(x) + " ")
                End If
                If contador = 3 Then
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.Write(v(x) + " ")
                End If
                If contador = 4 Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write(v(x) + " ")
                End If
            Else
                Console.WriteLine()
                contador = 0
            End If
        Next
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

    End Sub
End Module
