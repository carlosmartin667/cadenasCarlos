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
        cadena = "El �ndice TIOBE es un �ndice elaborado por una empresa de software holandesa que se especializa en la evaluaci�n y seguimiento de la calidad de los programas inform�ticos. Actualmente, la empresa revisa en tiempo real m�s de 300 millones de c�digos de diversos programas inform�ticos por d�a actualizando mes a mes su �ndice."
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
