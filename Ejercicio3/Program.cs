using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /* Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un dia de la semana: ");
            var d = Console.ReadLine();
            switch (d)
            {
                case "Lunes":
                case "Martes":
                case "Miercoles":
                case "Jueves":
                case "Viernes":
                    Console.WriteLine("No es fin de semana ");
                    break;
                case "Sabado":
                case "Domingo":
                    Console.WriteLine("Es fin de semana");
                    break;
                default:
                    Console.WriteLine("Error en el dia introducido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
