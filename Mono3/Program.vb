'Ejercicio 3:
'1.	A partir de un texto:
'2.	Mostrarlo en pantalla.
'3.	Pasar el texto a un vector.
'4.	Recorrer el vector.
'5.	Determinar si el elemento o palabra es uno de artículos (el, la, los, las, un, una, unos, unas).
'6.	Las palabras que no son artículos de la lista mostrarlas en color blanco y a los artículos en color rojo, deben formar un párrafo.

Module Module1

    Sub Main()
        Dim texto, V() As String
        Dim X As Integer

        '1.	A partir de un texto:
        texto = "De pronto se acercó un gato muy peludo, asomó su nariz en el agujero y los ratones envidiosos se arrinconaron muy asustados. Cuando gritaron, el vecino los escuchó y se acercó al gato lleno de valor y como pudo lo alejó de la puerta. Quedó tan cansado el pobre ratón que los envidiosos salieron a agradecerle el favor y por fin lo invitaron a comer."

        '2.	Mostrarlo en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3.	Pasar el texto a un vector.
        V = texto.Split(" ")

        '4.	Recorrer el vector.
        For X = 0 To V.Length - 1
            If V(X) = "el" Or V(X) = "la" Or V(X) = "los" Or V(X) = "las" Or V(X) = "un" Or V(X) = "una" Or V(X) = "unos" Or V(X) = "unos" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(V(X) & " ")
            Else
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(V(X) & " ")
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
