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
        cadena = "El �ndice TIOBE es un �ndice elaborado por una empresa de software holandesa que se especializa en la evaluaci�n y seguimiento de la calidad de los programas inform�ticos. Actualmente, la empresa revisa en tiempo real m�s de 300 millones de c�digos de diversos programas inform�ticos por d�a actualizando mes a mes su �ndice."

        Console.WriteLine(cadena)


        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()


        Dim v() As String
        v = cadena.Split(" ")

        Dim x As Integer

        For x = 0 To v.Length - 1
            'Console.WriteLine(v(x))
            subcad = v(x)
            For I = 0 To subcad.Length - 1
                letra = subcad.Substring(I, 1)

                If letra = "el" Or letra = "la" Or letra = "los" Or letra = "las" Or letra = "un" Or letra = "una" Or letra = "unos" Or letra = "unas" Then
                    contador = contador + 1
                End If
                'Console.WriteLine(letra)
            Next

            If contador >= 1 Then

                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(v(x) + " ")
                Console.ForegroundColor = ConsoleColor.White
                contador = 0
            Else
                Console.Write(v(x) + " ")
            End If

        Next

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
    End Sub
End Module