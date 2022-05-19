using System;

namespace Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elevador = 0;

            Console.Write("\nInforme qual andar você se encontra: ");

            int pessoa = int.Parse(Console.ReadLine());

            Console.Write("\nInforme para qual andar você deseja ir: ");

            int andar = int.Parse(Console.ReadLine());

            elevador = pessoa;

            if (pessoa < andar)
            {
                Subir(elevador, andar);
            }
            else
            {
                Descer(elevador, andar);
            }

            string[] a = null;
            Main(a);
        }

        public static void Subir(int elevador, int andar)
        {
            while (elevador < andar)
            {
                if (elevador == (andar - 1))
                {
                    Console.WriteLine($"\nChegamos no andar {elevador + 1}");
                }
                else
                {
                    Console.WriteLine($"\nSubindo para o andar {elevador + 1}");
                }

                elevador++;
            }
        }

        public static void Descer(int elevador, int andar)
        {
            int chegada = elevador;

            while (andar < elevador)
            {
                chegada--;
                if (andar == (elevador - 1))
                {
                    Console.WriteLine($"\nChegamos no andar {chegada}");
                }
                else
                {
                    Console.WriteLine($"\nDescendo para o andar {elevador - 1}");
                }
                elevador--;
            }
        }
    }
}
