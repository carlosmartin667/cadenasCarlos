Module Module1

    'Cuenta las may�sculas, min�sculas, n�meros y algunas teclas especiales.
    Sub Main()
        Dim nota As String
        nota = "Mucho seguramente escucharon hablar del virus que afect� a Facebook, en el cual un link a un supuesto video porno activaba un virus en las computadoras de los usuarios. A ra�z de esto la compa��a decidi� tomar cartas en el asunto, y declar� estar trabajando en conjunto con varias empresas de seguridad inform�tica, Kaspersky Lab, ESET, F-Secure y Trend Micro, para detectar actividad inusual en las cuentas fraudulentas."

        Dim x, may, min, num, esp As Integer
        Dim letra As String

        For x = 0 To nota.Length - 1
            letra = nota.Substring(x, 1)

            If letra >= "A" And letra <= "Z" Then
                may = may + 1
            End If

            If letra >= "a" And letra <= "z" Then
                min = min + 1
            End If

            If letra >= "0" And letra <= "9" Then
                num = num + 1
            End If

            If letra = "?" Or letra = "*" Or letra = "-" Or letra = "+" Or letra = "." Then
                esp = esp + 1
            End If

        Next

        Console.WriteLine(nota)
        Console.WriteLine()
        Console.WriteLine("May�sculas: " + CStr(may))
        Console.WriteLine("Min�sculas: " + CStr(min))
        Console.WriteLine("N�meros: " + CStr(num))
        Console.WriteLine("Especiales: " + CStr(esp))

        Console.ReadLine()
    End Sub

End Module
