using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6__Amortizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            double couta;
            float i, a, co;
            n = 5;
            Console.WriteLine("Ingrese el monto del capital prestado");
            co = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de couta");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese a que porcentaje es el prestamo");
            i = float.Parse(Console.ReadLine());
            couta = (co * i) / (1 - (1 + i)) - n;
            Console.WriteLine("Este es el total de tu cuota mensual " + couta);
            Console.ReadKey();
        }
    }
}
