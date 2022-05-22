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
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quantos tempo deseja contar ?");

            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplicador = 1;
            if (tipo == 'm')
                multiplicador = 60;

            if (time == 0)
                Sair();

            PreStart(time * multiplicador);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar");
            Thread.Sleep(1000);
            Console.WriteLine("E");
            Thread.Sleep(1000);
            Console.WriteLine("Vaiiii");
            Thread.Sleep(1500);
            Start(time);
        }
        static void Sair()
        {

            Console.Clear();

            System.Environment.Exit(0);

            Console.WriteLine("Sistema Finalizado !! ");


        }

        static void Start(int time)
        {
            Console.Clear();
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("StopWatch finalizado ... Retornando ao menu");
            Thread.Sleep(2500);
            Console.Clear();
            Menu();
        }
    }
}

