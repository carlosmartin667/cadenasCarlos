'Ejercicio 6:
'1.	A partir de un texto:
'2.	Mostrarlo en pantalla.
'3.	Encontrar y colorear todas las vocales en rojo.
Module Module1

    Sub Main()
        Dim texto, subTexto As String
        Dim X As Integer

        '1.	A partir de un texto:
        texto = "De pronto se acercó un gato muy peludo, asomó su nariz en el agujero y los ratones envidiosos se arrinconaron muy asustados. Cuando gritaron, el vecino los escuchó y se acercó al gato lleno de valor y como pudo lo alejó de la puerta. Quedó tan cansado el pobre ratón que los envidiosos salieron a agradecerle el favor y por fin lo invitaron a comer."

        '2.	Mostrarlo en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3.	Encontrar y colorear todas las vocales en rojo.
        For X = 0 To texto.Length - 1
            subTexto = texto.Substring(X, 1)
            If subTexto = "a" Or subTexto = "e" Or subTexto = "i" Or subTexto = "o" Or subTexto = "u" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(subTexto)
            Else
                Console.ForegroundColor = ConsoleColor.Gray
                Console.Write(subTexto)
            End If
        Next
        Console.ReadLine()
    End Sub

End Module