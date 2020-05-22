using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int metros;
            double cm;
            double km;
            Console.WriteLine("Entre com a medida em Metros:");
            metros = Convert.ToInt16(Console.ReadLine());

            km = metros / 1000.0;
            cm = metros / 0.010000;

            Console.WriteLine("--- Equivalência ---");
            Console.WriteLine(metros);
            Console.WriteLine(km);
            Console.WriteLine(cm);
        }
    }
}
