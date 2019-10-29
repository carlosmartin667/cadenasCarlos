'Es necesario importar la libreria System.Threading de punto net para usar Thread.Sleep
Imports System.Threading

Module Module1

    Sub Main()
        Dim cad As String

        'Incializa cad.
        cad = "Este prototipo es el primer veh�culo construido desde el comienzo para conducci�n aut�noma, afirma Google. Puede conducir, frenar y reconocer peligros sin intervenci�n humana. Tiene m�s capacidades que el prototipo que Google present� en mayo pasado, que era tan rudimentario que ten�a faros delanteros falsos."

        Dim x As Integer
        Dim letra As Char

        'Muestra la cadena original.
        Console.WriteLine(cad)

        'Deja una l�nea en blanco.
        Console.WriteLine()

        'Length devuelve la longitud en caracteres de la cadena.
        For x = cad.Length - 1 To 0 Step -1
            'Substring devuelve de la posicion x 1 caracter
            'o sea una letra por cada ciclo del for.
            letra = cad.Substring(x, 1)

            'Imprime o muestra por consola cada letra obtenida.
            Console.Write(letra)

            'Demora la ejecuci�n 100 milisegundos.
            Thread.Sleep(100)
        Next

        Console.ReadLine()
    End Sub

End Module
