using System;
using System.Collections.Generic;

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto, palabra;
            int contador = 0;
            int palabrasRepetidasContador = 0;
            List<string> a = new List<string>();
            var duplicates = new List<string>();
            var duplicates2 = new List<string>();
            var duplicatesCaantidad = new List<int>();
       
            texto = "La tecnología 5G se muestra al mundo como uno de los pilares del futuro más próximo. Los smartphones de los años venideros tendrán como base la quinta generación de cobertura, y muchas son las marcas que ya han apostado por este tipo de soportes. Xiaomi, Samsung, Huawei, LG… Los fabricantes ya están trabajando en terminales con tecnología 5G integrada en sus procesadores, el único problema es que los países todavía no están preparados para recibir estas novedades.";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);

            string[] v = new string[texto.Length];
            texto = texto.Replace(".", " ");
            texto = texto.Replace(",", " ");
            texto = texto.Replace(":", " ");
            texto = texto.Replace(";", " ");
            texto = texto.Replace("?", " ");

            for (int i = 0; i < 10; i++)
            {
                texto = texto.Replace(Convert.ToString(i), "#");
            }

            v = texto.Split(" ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.WriteLine();

            do
            {
                Console.WriteLine("INGRESE PALABRA QUE QUIERE BUSCAR ??");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                palabra = Console.ReadLine();
                Console.WriteLine();

                if (palabra == "0")
                {
                    break;
                }
                for (int i = 0; i < v.Length; i++)
                {
                    if (palabra == v[i])
                    {
                        contador = contador + 1;

                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();


                if (contador > 0)
                {
                    for (int i = 0; i < v.Length; i++)
                    {
                        if (palabra == v[i])
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(v[i] + " ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            contador = 0;
                        }
                        else
                        {
                            Console.Write(v[i] + " ");
                            contador = 0;
                        }
                    }
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("NO SE ENCONTRO LA PALABRA  ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    contador = 0;
                }
            } while (true);


            foreach (var s in v)
            {
                if (s != "")
                {
                    if (!a.Contains(s))
                        a.Add(s);
                    else
                        duplicates.Add(s);
                }

            }
            foreach (var item in duplicates)
            {
                if (!duplicates2.Contains(item))
                    duplicates2.Add(item);
            }



            foreach (var s in duplicates2)
            {

                for (int i = 0; i < v.Length; i++)
                {
                    if (s == v[i])
                    {
                        contador = contador + 1;
                    }
                }

                duplicatesCaantidad.Add(contador);
                contador = 0;
                palabrasRepetidasContador = palabrasRepetidasContador + 1;
            }


            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < palabrasRepetidasContador; i++)
            {
                Console.Write("palabra  repetida :");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {duplicates2[i] } ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(", candidad de repeticiones : ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{duplicatesCaantidad[i]} ");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
            }



            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
