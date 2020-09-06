using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4__Eliga_una_opcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige una opcion\n" +
               "\ns.- Sumar" +
               "\nr.- Restar" +
               "\ne.- Salir\n");
            float num1;
            num1 = 0;
            float num2;
            num2 = 0;
            float resul;
            string s = null;
            s = Console.ReadLine();
            switch (s)
            {
                case "s":
                    Console.WriteLine("Has elegido la opcion de sumar");
                    Console.WriteLine("Ingrese primer numero");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resul = num1 + num2;
                    Console.WriteLine("El resultado de su operacion es: " + resul);
                    Console.ReadKey();

                    break;

                case "r":
                    Console.WriteLine("Has elegido la opcion de restar");
                    Console.WriteLine("Ingrese primer numero");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resul = num1 - num2;
                    Console.WriteLine("El resultado de su operacion es: " + resul);
                    Console.ReadKey();

                    break;
                case "e":
                    Console.WriteLine("Gracias por usar nuestra aplicacion :D!");
                    Console.ReadKey();


                    break;
                default:
                    Console.WriteLine("Opcion invalidad");
                    break;
            }
        }
    }
}
