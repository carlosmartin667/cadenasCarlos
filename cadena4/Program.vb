Module Module1

    'Dado un texto, convertir la primer letra de cada palabra a mayùscula y el resto de la palabra a minùscula.
    Sub Main()
        Dim lista(), texto, salida As String
        Dim i As Integer

        texto = "Hostinger en Argentina ayuda a la gente a crear su página de personal " +
        "brindando hosting web barato y excepcional para la creación de su blog personal " +
        "o página web de negocio . Además contamos con soporte dedicado las 24 horas del " +
        "día. No importa qué sitio web que estés creando, debes saber que es posible " +
        "ahorrar de forma inteligente. Aquí hay unas cuantas características que hacen " +
        "de Hostinger el pionero en hosting web Premium y asequible."

        '1 Muestra la cadena texto original.
        Console.WriteLine(texto)

        '2 Deja una line a de seaparación.
        Console.WriteLine()

        '3 Pasa texto al vector lista.
        lista = texto.Split(" ")

        '4 Pasar a mayúsucla la primer letra de cada elemento de lista y el resto del elemnto a minúscula.
        For i = 0 To lista.Length - 1
            lista(i) = lista(i).Substring(0, 1).ToUpper + lista(i).Substring(1).ToLower
        Next

        '5 Crea un nuevo vector String salida a partir de los elementos de listas sepaádolos por un espacion en blanco.
        salida = String.Join(" ", lista)

        '6 Mostrar el resultado.
        Console.WriteLine(salida)

        '7 Evita que se cierre la consola.
        Console.ReadLine()

    End Sub

End Module
