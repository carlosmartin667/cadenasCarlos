Module Module1

    Sub Main()
        Dim cadena, lista(), reverso As String
        Dim x, cont As Integer

        cadena = "abajaba, abanaba, ababa, aboba, acurruca, adamada, alela, anona, anilina, apocopa, ara�ara, arara, arenera, arra, asesa, ateta, aviva, azuza, da�ad, datad, debed, elle, erare, erre, nadan, narran, neven, nomon, radar, rajar, rallar, rapar, rasar, rayar, recocer, reconocer, rodador, rotor, sa�as, sacas, saeteas, sagas, sajas, salas, saldadlas, sallas, samas, sanas, sanidinas, sayas, sebes, sedes, selles, senes, seres, sobos, soldadlos, solos, somarramos, sometemos, somos, sopapos, soros, sosos, sotos, aba�aba, abalaba, aballaba, abatataba, acoca, afofa, afufa, alola, apipa, dallad, dimid, napan, rever, sexes, somatamos, yatay, kayak, ososo, orero, razar,"
        'cadena = "Palabras capicuas. Las palabras pal�ndromas son las que se leen igual hacia adelante que hacia atr�s: Nosotros encontramos mas de 80 palabras que se escriben igual de derecha e izquierda en idioma espa�ol. Este es el listado de palabras pal�ndromas:"

        'Obtiene un vector o lista con  elementos separados por coma y espacio.
        lista = cadena.Split(", ")

        For x = 0 To lista.Length - 1
            'Esta funci�n dvuelve el string al rev�s.
            reverso = StrReverse(lista(x))

            If lista(x) = reverso Then
                cont = cont + 1
            End If

            'observar como puedo pasar x de integer a cadena para poder concatenar.
            'hacer CStr(x) y x.ToString da lo mismo.
            Console.WriteLine(x.ToString + " - " + lista(x) + " - " + reverso)

        Next x

        Console.WriteLine()
        Console.WriteLine("Cantidad de palabras pal�dromas: " + CStr(cont))

        Console.ReadLine()

    End Sub

End Module
