using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio19
{
    class Ejercicio_19
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(3);

            Console.WriteLine(sumador1.Sumar(10,5));
            Console.WriteLine(sumador1.Sumar("ahre", "ke dice"));

            Console.WriteLine("Cantidad de sumas en sumador 1: " + (int)sumador1);
            Console.WriteLine("Cantidad de sumas en sumador 2: " + (int)sumador2);

            Console.WriteLine("Los sumadores hicieron la misma cantidad de sumas? " + (sumador1|sumador2));
            Console.WriteLine(sumador1.Sumar(24, 53));
            Console.WriteLine("Cantidad de sumas total: " + (sumador1+sumador2));





            Console.ReadLine();
        }
    }
}
