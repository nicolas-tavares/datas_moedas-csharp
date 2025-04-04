using System;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
        }

        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("CURSO C# - Datas & Moedas");
            Console.WriteLine("\n============\n"); // "\n" para quebrar uma linha
            Console.WriteLine("1 - Aula de Datas");
            Console.WriteLine("2 - Aula de Moedas");
            Console.WriteLine("0 - Sair\n");

            Console.WriteLine("Digite sua opção:");



            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Data.Show(); break;
                case 2: Moeda.Show(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}
