using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    /*Solicitar un número al usuario y generar un Array con N números aleatorios. 
     * Por ejemplo, si el usuario introduce 4, el resultado por consola debería ser: 23, 34, 234, 11*/

    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Introduce un numero del 1 al 5"); // Pedimos un numero en un rango de 1 a 5 para que el array tampoco sea innecesariamente grande
            var nUsuario = Convert.ToInt32(Console.ReadLine());
            while (nUsuario < 1 || nUsuario > 5)
            {
                Console.WriteLine("Error \nIntroduce un numero del 1 al 5"); // Pedimos un numero en un rango de 1 a 5 para que el array tampoco sea innecesariamente grande
                nUsuario = Convert.ToInt32(Console.ReadLine());
            }
            int[] nArray = new int[nUsuario];
            Console.Write("Los numeros aleatorios de tu array son: ");
            for (int i = 0; i < nArray.Length; i++)
            {
                int rand = rnd.Next(0, 101);
                nArray[i] = rand;
                if (i + 1 != nArray.Length)
                {
                    Console.Write($"{nArray[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{nArray[i]}");
                }

            }
        }
    }
}
