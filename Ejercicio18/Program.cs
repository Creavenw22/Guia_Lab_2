using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(2, 2);
            Punto punto2 = new Punto(6, 6);

            Console.WriteLine("Puntos: ");
            Console.WriteLine(punto1);
            Console.WriteLine(punto2);

            Rectangulo rectangulo = new Rectangulo(punto1, punto2);

            Console.WriteLine("Rectangulo:\n");
            
            rectangulo.Mostrar();

            Console.ReadLine();
        }
    }
}
