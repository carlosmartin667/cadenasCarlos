'Ejercicio 3:
'A partir de un texto:
'Mostrarlo en pantalla.
'Pasar el texto a un vector.
'Recorrer el vector.
'Determinar si el elemento o palabra es uno de art�culos (el, la, los, las, un, una, unos, unas).
'Las palabras que no son art�culos de la lista mostrarlas en color blanco y a los art�culos en color rojo, deben formar un p�rrafo.


Imports System

Module Program
    Sub Main(args As String())
        Dim cadena, subcad, palabra, letra As String
        Dim contador = 0
        Dim largo = 0
        cadena = "El �ndice TIOBE es un �ndice "


        Dim v() As String
        v = cadena.Split(" ")

        Dim x As Integer

        For x = 0 To v.Length - 1
            Console.WriteLine(v(x))
            subcad = v(x)
            For I = 0 To subcad.Length - 1

                If letra >= "A" And letra <= "Z" Then
                    contador = contador + 1
                End If
                letra = subcad.Substring(I, 1)
                Console.WriteLine(letra)


            Next
            Console.WriteLine()



        Next

        Console.WriteLine(contador)
    End Sub
End Module
