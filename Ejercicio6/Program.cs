using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    /*
      Solicitar un número al usuario y un carácter. Crear una pirámide con N filas y el carácter solicitado. Por ejemplo, si el usuario introduce 5 y * el resultado por consola debería ser:

        *
        **
        * *
        *  *
        *****
         
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero: ");
            var nUsuario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un caracter: ");
            var charUsuario = Console.ReadLine();

            for (int i = 0; i < nUsuario; i++)
            {
                for (int j = 0; j <= i; j++) // Limitamos en "i" para crear el escalonado
                {
                    if (j == 0 || j == i || i == nUsuario - 1) // Condicional para hacer el espacio interior de la piramide
                    {
                        Console.Write(charUsuario);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine(" ");
            }

        }
    }
}
