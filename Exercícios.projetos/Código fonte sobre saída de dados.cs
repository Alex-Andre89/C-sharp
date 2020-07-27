using System;
using System.Globalization;

namespace Exercicio_código_fonte
{
    class Program
    {

        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais ");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais ");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();


        }
    }
}
