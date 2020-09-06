using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Evuluar_x_es_mayor_que_y
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
           
            Console.WriteLine("Ingrese un primer valor");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo valor");
            y = double.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("El Numero {0} es mayor que: {1} ", x, y);

            }
            else
            {
                Console.WriteLine("El Numero {1} es menor que: {0} ", y, x);
            }
            Console.ReadKey();
        }
    }
}
