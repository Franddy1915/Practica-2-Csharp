using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_Ejercicio_1__Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par ");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
