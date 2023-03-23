using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{

    /*Solicite dos números y diga cual es el mayor.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un primer numero: ");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un segundo numero: ");
            var n2 = Convert.ToInt32(Console.ReadLine());


            // Condicional si un numero es mayor que otro. Hay que tener en cuenta que no se controla si son iguales, por lo que tomara el segundo condicional como valido
            if(n1 > n2){ // Si el primer numero es mayor que el segundo
                Console.WriteLine($"{n1} es mayor que {n2}");
                }else{ // Sino el segundo es mayor que el primero
                    Console.WriteLine($"{n2} es mayor que {n1}");
            }   
            Console.ReadLine();
            }
    }
}
