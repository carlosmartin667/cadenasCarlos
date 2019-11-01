
'Ejercicio 4:
'1.	A partir de un texto:
'2.	Mostrarlo en pantalla.
'3.	Encontrar cada unos de los artículos de la lista (el, la, los, las, un, una, unos, unas) e imprimir el 
'   artículo y la posición dentro de la cadena de cada aparición.
'4.	Contar y mostrar cuantos artículos de cada uno se encontraron.
Module Module1

    Sub Main()
        Dim texto, V() As String
        Dim X, Tam, AcumTam As Integer
        Dim ContEl, PosEl As Integer
        Dim ContLa, PosLa As Integer
        Dim ContLos, PosLos As Integer

        '1.	A partir de un texto:
        texto = "De pronto se acercó un gato muy peludo, asomó su nariz en el agujero y los ratones envidiosos se arrinconaron muy asustados. Cuando gritaron, el vecino los escuchó y se acercó al gato lleno de valor y como pudo lo alejó de la puerta. Quedó tan cansado el pobre ratón que los envidiosos salieron a agradecerle el favor y por fin lo invitaron a comer."

        '2.	Mostrarlo en pantalla.
        Console.WriteLine(texto)
        Console.WriteLine()

        '3.	Encontrar cada unos de los artículos de la lista (el, la, los, las, un, una, unos, unas) e imprimir el 
        '   artículo y la posición dentro de la cadena de cada aparición.
        V = texto.Split(" ")

        For X = 0 To V.Length - 1
            Tam = V(X).Length
            If V(X) = "el" Then
                ContEl = ContEl + 1
                PosEl = PosEl + AcumTam
                Console.WriteLine("Posición " & PosEl & ": el.")
            End If

            If V(X) = "la" Then
                ContLa = ContLa + 1
                PosLa = PosLa + AcumTam
                Console.WriteLine("Posición " & PosLa & ": la.")
            End If

            If V(X) = "los" Then
                ContLos = ContLos + 1
                PosLos = PosLos + AcumTam
                Console.WriteLine("Posición " & PosLos & ": los.")
            End If
            AcumTam = AcumTam + Tam
        Next

        Console.WriteLine()
        Console.WriteLine("Cantidad de veces que aparece el articulo el: " & ContEl)
        Console.WriteLine("Cantidad de veces que aparece el articulo la: " & ContLa)
        Console.WriteLine("Cantidad de veces que aparece el articulo los: " & ContLos)
        Console.ReadLine()
    End Sub

End Module