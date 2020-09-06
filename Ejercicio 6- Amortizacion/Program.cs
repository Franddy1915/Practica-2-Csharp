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
            //formula para calcular cuota fija
            ///de un prestamo usando el metodo frances de cuota fija

            double Monto = 0;
            int Plazos = 0;
            double taza = 0;

            Console.WriteLine("Ingrese el monto solicitado");
            Monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los plazos");
            Plazos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la taza");
            taza = double.Parse(Console.ReadLine());


            //A = 1-(1+taza)^-plazos
            int p = Plazos * -1;
            double b = (1 + taza);
            double A = (1 - Math.Pow(b, p)) / taza;

            //Cuota Fija = Monto / A;
            double Cuota_F = Monto / A;

            Console.WriteLine("el valor de la cuota Fija es:{0:C} ", Cuota_F);
            Console.ReadKey();
        }
    }
}
