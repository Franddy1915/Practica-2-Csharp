using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_2_Evaluacion_por_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("ingrese una edad");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 0 && age <= 10)

            {
                Console.WriteLine("Es un niño");
            }
            else if (age >= 11 && age <= 16)
            {
                Console.WriteLine("Es un Adolecente");
            }
            else if (age >= 17 && age <= 55)
            {
                Console.WriteLine("Es un Adulto");
            }
            else if (age >= 56 && age <= 200)
            {
                Console.WriteLine("Tu eres el puto amo!!!");
            }

            else

                Console.WriteLine("Ingresa otra edad, Edad invalida");
            Console.ReadKey();
        }
    }
}
