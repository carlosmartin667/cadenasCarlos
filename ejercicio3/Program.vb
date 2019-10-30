'Ejercicio 3:
'A partir de un texto:
'Mostrarlo en pantalla.
'Pasar el texto a un vector.
'Recorrer el vector.
'Determinar si el elemento o palabra es uno de artículos (el, la, los, las, un, una, unos, unas).
'Las palabras que no son artículos de la lista mostrarlas en color blanco y a los artículos en color rojo, deben formar un párrafo.


Imports System

Module Program
    Sub Main(args As String())
        Dim cadena, subcad, palabra, letra As String
        Dim contador = 0
        Dim largo = 0
        cadena = "El Índice TIOBE es un índice "


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
