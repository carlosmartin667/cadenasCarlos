Module Module1

    Sub Main()
        'Revision m�todos clase string

        Dim cadena, subcad As String
        cadena = "El �ndice TIOBE es un �ndice elaborado por una empresa de software holandesa que se especializa en la evaluaci�n y seguimiento de la calidad de los programas inform�ticos. Actualmente, la empresa revisa en tiempo real m�s de 300 millones de c�digos de diversos programas inform�ticos por d�a actualizando mes a mes su �ndice."
        Console.WriteLine(cadena)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Substring(0,15): Obtiene una subcadena de 15 caracteres.")
        subcad = cadena.Substring(0, 15)
        Console.WriteLine(subcad)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Substring(19,10): Obtiene una subcadena de 10 caracteres a partir de la posicion 20.")
        subcad = cadena.Substring(19, 10)
        Console.WriteLine(subcad)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Substring(119): Obtiene una subcadena a partir de la posicion 200 hasta el final.")
        subcad = cadena.Substring(199)
        Console.WriteLine(subcad)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Length: Devuelve la longitud de la cadena.")
        Console.WriteLine(cadena.Length)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("ToUpper: Pone a mayuscula toda la cadena.")
        subcad = cadena.ToUpper
        Console.WriteLine(subcad)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("ToLower: Pone la cadena a minuscula.")
        subcad = cadena.ToLower
        Console.WriteLine(subcad)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("StrReverse: Pone la cadena al rev�s o la invierte.")
        subcad = StrReverse(cadena)
        Console.WriteLine(subcad)

        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Split: Obtener un vetor con las palabras.")

        Dim v() As String
        v = cadena.Split(" ")

        Dim x As Integer

        For x = 0 To v.Length - 1
            Console.WriteLine(v(x))
        Next

        'LastIndex
        'IndexOf
        'InStr
        'Join
        'InStrRev
        'Replace
        'Space
        'Trim
        'LTrim
        'RTrim

        Console.ReadLine()

    End Sub

End Module
