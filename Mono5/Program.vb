'Ejercicio 5:
'1.	A partir de un texto:
'2.	Mostrarlo en pantalla.
'3.	Encontrar las vocales y reemplazarlas seg�n la siguiente lista (a - 1, e - 2, i - 3, o - 4, u - 5)
'4.	Mostrar como queda la nueva cadena o la cadena original modificada.
Module Module1

    Sub Main()
        Dim texto As String

        '1.	A partir de un texto:
        texto = "De pronto se acerc� un gato muy peludo, asom� su nariz en el agujero y los ratones envidiosos se arrinconaron muy asustados. Cuando gritaron, el vecino los escuch� y se acerc� al gato lleno de valor y como pudo lo alej� de la puerta. Qued� tan cansado el pobre rat�n que los envidiosos salieron a agradecerle el favor y por fin lo invitaron a comer."

        '2.	Mostrarlo en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3.	Encontrar las vocales y reemplazarlas seg�n la siguiente lista (a - 1, e - 2, i - 3, o - 4, u - 5)
        texto = texto.Replace("a", "1")
        texto = texto.Replace("e", "2")
        texto = texto.Replace("i", "3")
        texto = texto.Replace("o", "4")
        texto = texto.Replace("u", "5")

        '4.	Mostrar como queda la nueva cadena o la cadena original modificada.
        Console.WriteLine(texto)
        Console.ReadLine()
    End Sub

End Module