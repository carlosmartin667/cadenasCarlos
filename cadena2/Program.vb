Module Module1

    Sub Main()

        Dim cad1, cad2, cad3 As String
        Dim n As Integer
        Dim texto As String

        cad1 = "Esto es una prueba de variables STRING."

        cad2 = "Continuación del trabajo con cadenas."

        cad3 = cad1 & " " + cad2

        Console.WriteLine(cad3)

        texto = "Esto es el valor de n : "
        n = texto.Length

        Console.WriteLine(texto + CStr(n))

        Console.WriteLine("Cartel " + CStr(n))

        Console.ReadLine()

    End Sub

End Module
