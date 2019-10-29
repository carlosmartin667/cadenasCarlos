'Ejercicio 1:
'A partir de una cadena de texto:
'Mostrar en pantalla.
'Solicitar al usuario ingrese una palabra a buscar en el texto.
'Si la palabra se encuentra mostrar el texto con la palabra coloreada en rojo sino mostrar el cartel no La palabra no se encuentra.


Imports System

Module Program
    Sub Main(args As String())
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Red
        Console.Clear()


        Dim cadena, subcad, palabra As String
        cadena = "El Índice TIOBE es un índice elaborado por una empresa de software holandesa que se especializa en la evaluación y seguimiento de la calidad de los programas informáticos. Actualmente, la empresa revisa en tiempo real más de 300 millones de códigos de diversos programas informáticos por día actualizando mes a mes su índice."
        Console.WriteLine(cadena)


        Dim v() As String
        v = cadena.Split(" ")

        palabra = Console.ReadLine()

        Console.WriteLine()
        Console.WriteLine(palabra)



        Dim x As Integer

        For x = 0 To v.Length - 1

            If palabra = v(x) Then
                Console.WriteLine(v(x))
            End If

        Next


    End Sub
End Module
