using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("----------------------- CRÔNOMETRO -------------------------");
            Console.WriteLine("         Digite o tempo para contagem no formato MM:SS      ");
            Console.Write("                           ");
            string entrada = Console.ReadLine();
            string[] tempoTotal = entrada.Split(":");
            int tempo = int.Parse(tempoTotal[1]) + (int.Parse(tempoTotal[0]) * 60);

            Start(tempo);
        }
        static void Start(int tempo)
        {
            Console.Clear();
            Console.Write("Ready");
            Thread.Sleep(150);
            Console.Write(".");
            Thread.Sleep(150);
            Console.Write(".");
            Thread.Sleep(150);
            Console.WriteLine(".");

            Console.Write("Set");
            Thread.Sleep(150);
            Console.Write(".");
            Thread.Sleep(150);
            Console.Write(".");
            Thread.Sleep(150);
            Console.WriteLine(".");

            Console.WriteLine("GO!");
            Thread.Sleep(1500);

            int minutos = 0;
            int segundos = 0;

            for (int i = 0; i <= tempo; i++)
            {
                Console.Clear();

                Console.WriteLine();
                Console.Write("         ");

                if(segundos == 60)
                {
                    minutos++;
                    segundos = 0;
                }

                Console.WriteLine($"{minutos.ToString("00")}:{segundos.ToString("00")}");
                segundos++;

                Thread.Sleep(1000);

            }

            Thread.Sleep(3000);

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("         Fim da contagem!");
            Thread.Sleep(3000);

            Console.Write("Deseja realizar nova contagem? <S/N> ");
            string entrada = Console.ReadLine().ToUpper();
            if (entrada == "S")
            {
                Menu();
            }
        }
    }
}
