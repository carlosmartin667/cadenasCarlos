Module Module1

    'Dado un texto, convertir la primer letra de cada palabra a may�scula y el resto de la palabra a min�scula.
    Sub Main()
        Dim lista(), texto, salida As String
        Dim i As Integer

        texto = "Hostinger en Argentina ayuda a la gente a crear su p�gina de personal " +
        "brindando hosting web barato y excepcional para la creaci�n de su blog personal " +
        "o p�gina web de negocio . Adem�s contamos con soporte dedicado las 24 horas del " +
        "d�a. No importa qu� sitio web que est�s creando, debes saber que es posible " +
        "ahorrar de forma inteligente. Aqu� hay unas cuantas caracter�sticas que hacen " +
        "de Hostinger el pionero en hosting web Premium y asequible."

        '1 Muestra la cadena texto original.
        Console.WriteLine(texto)

        '2 Deja una line a de seaparaci�n.
        Console.WriteLine()

        '3 Pasa texto al vector lista.
        lista = texto.Split(" ")

        '4 Pasar a may�sucla la primer letra de cada elemento de lista y el resto del elemnto a min�scula.
        For i = 0 To lista.Length - 1
            lista(i) = lista(i).Substring(0, 1).ToUpper + lista(i).Substring(1).ToLower
        Next

        '5 Crea un nuevo vector String salida a partir de los elementos de listas sepa�dolos por un espacion en blanco.
        salida = String.Join(" ", lista)

        '6 Mostrar el resultado.
        Console.WriteLine(salida)

        '7 Evita que se cierre la consola.
        Console.ReadLine()

    End Sub

End Module
