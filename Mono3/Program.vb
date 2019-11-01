'Ejercicio 3:
'1.	A partir de un texto:
'2.	Mostrarlo en pantalla.
'3.	Pasar el texto a un vector.
'4.	Recorrer el vector.
'5.	Determinar si el elemento o palabra es uno de art�culos (el, la, los, las, un, una, unos, unas).
'6.	Las palabras que no son art�culos de la lista mostrarlas en color blanco y a los art�culos en color rojo, deben formar un p�rrafo.

Module Module1

    Sub Main()
        Dim texto, V() As String
        Dim X As Integer

        '1.	A partir de un texto:
        texto = "De pronto se acerc� un gato muy peludo, asom� su nariz en el agujero y los ratones envidiosos se arrinconaron muy asustados. Cuando gritaron, el vecino los escuch� y se acerc� al gato lleno de valor y como pudo lo alej� de la puerta. Qued� tan cansado el pobre rat�n que los envidiosos salieron a agradecerle el favor y por fin lo invitaron a comer."

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
