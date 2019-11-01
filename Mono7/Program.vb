Module Module1

    Sub Main()
        Dim texto, V() As String
        Dim X, Cont As Integer

        texto = "a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a"

        V = texto.Split(" ")

        For X = 0 To texto.Length - 1
            Console.Write(V(X))
            If Cont = 9 Then
                Console.WriteLine()
                Cont = 0
            End If
            Cont = Cont + 1
        Next
        Console.ReadLine()
    End Sub

End Module
