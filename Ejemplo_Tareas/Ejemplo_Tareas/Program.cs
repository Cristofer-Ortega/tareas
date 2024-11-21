using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Introduce hasta 5 números:");

        while (numeros.Count < 5)
        {
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
                break;

            if (int.TryParse(entrada, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido o 'fin' para terminar.");
            }
        }

        // Ordenar los números
        var numerosOrdenados = await Task.Run(() => numeros.OrderBy(n => n).ToList());

        // Sumar los números
        var sumaTotal = await Task.Run(() => numerosOrdenados.Sum());

        Console.WriteLine("Números ordenados: " + string.Join(", ", numerosOrdenados));
        Console.WriteLine("Suma total: " + sumaTotal);
    }
}

