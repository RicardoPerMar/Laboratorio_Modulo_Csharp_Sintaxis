using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /*
     * Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // He elegido bucle for por la facilidad de su estructura aunque haya mas maneras de realizar el ejercicio

            for (int i = 0; i < 100; i++) // 1 - 100
            {
                if (i % 2 == 0) // Si el numero dividido entre 2 es igual a 0
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
