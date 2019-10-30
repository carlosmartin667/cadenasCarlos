'Ejercicio 1:
'A partir de una cadena de texto:
'Mostrar en pantalla.
'Solicitar al usuario ingrese una palabra a buscar en el texto.
'Si la palabra se encuentra mostrar el texto con la palabra coloreada en rojo sino mostrar el cartel no La palabra no se encuentra.


Imports System

Module Program
    Sub Main(args As String())
        'Console.BackgroundColor = ConsoleColor.White
        'Console.ForegroundColor = ConsoleColor.Red
        Console.Clear()
        Dim cadena, subcad, palabra As String
        Dim contador = 0
        cadena = "El Índice TIOBE es un índice elaborado por una empresa de software holandesa que se especializa en la evaluación y seguimiento de la calidad de los programas informáticos. Actualmente, la empresa revisa en tiempo real más de 300 millones de códigos de diversos programas informáticos por día actualizando mes a mes su índice."
        Console.WriteLine(cadena)
        Dim v() As String
        v = cadena.Split(" ")
        Console.WriteLine()
        Console.WriteLine("INGRESE PALABRA QUE QUIERE BUSCAR ??")
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Green
        palabra = Console.ReadLine()
        Console.WriteLine()
        Dim x As Integer
        For x = 0 To v.Length - 1
            If palabra = v(x) Then
                contador = contador + 1
            End If
        Next
        Console.ForegroundColor = ConsoleColor.White
        If contador >= 1 Then
            For x = 0 To v.Length - 1
                If palabra = v(x) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write(v(x) + " ")
                    Console.ForegroundColor = ConsoleColor.White
                Else
                    Console.Write(v(x) + " ")
                End If
            Next
        Else
            Console.BackgroundColor = ConsoleColor.White
            Console.Clear()

            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("NO SE ENCONTRO LA PALABRA  ")
            Console.Write("")
        End If
    End Sub
End Module
