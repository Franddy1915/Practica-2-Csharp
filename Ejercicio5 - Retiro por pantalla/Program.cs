using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5___Retiro_por_pantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            double monto, x, y;
            monto = 18675.33;
            x = 0;
            y = 0;
            Console.WriteLine("Bienvenido ");
            Console.WriteLine("Su balance disponible es de: " + monto);
            Console.WriteLine("Ingrese el monto a retirar");
            y = Convert.ToDouble(Console.ReadLine());
            x = monto - y;

            if (y <= monto)
            {
                Console.WriteLine("Su balance actual es de: " + x);
            }
            else if (y > monto)
            {
                Console.WriteLine("Ingrese otro monto, Balance no disponible");
            }
            else
            {
                Console.WriteLine("Monto invalido");
            }
            Console.ReadKey();
        }
    }
}
