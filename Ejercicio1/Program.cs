using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /*
     Solicite el nombre de una persona, su edad y el nombre de una ciudad. 
     Después de solicitar estos datos deberá mostrar por pantalla el siguiente mensaje: Te llamas y tienes <años> años. Bienvenido a
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce tu nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Introduce tu edad: ");
            var edad = Console.ReadLine();
            Console.Write("Introduce el nombre de una ciudad: ");
            var ciudad = Console.ReadLine();

            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años. Bienvenido a {ciudad}");
            Console.ReadLine();
        }
    }
}
