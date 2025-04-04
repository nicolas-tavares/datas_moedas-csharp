using System;
using System.Globalization;
using System.Text;


namespace Curso
{
    public static class Moeda
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("FORMATANDO NÚMEROS:");

            decimal valor = 1000.25m;
            var en = new CultureInfo("en-US");
            var br = new CultureInfo("pt-BR");
            var es = new CultureInfo("es-ES");

            // =================================== //

            Console.WriteLine("\nMOEDAS(C):");
            Console.WriteLine("EUA: " + valor.ToString("C", en)); // "C" de Currency (mostra em formato de moedas)
            Console.WriteLine("Brasil: " + valor.ToString("C", br));
            Console.WriteLine("Espanha: " + valor.ToString("C", es));

            // =================================== //

            Console.WriteLine("\n===============\n");

            Console.WriteLine("NÚMEROS(G):");
            Console.WriteLine("EUA: " + valor.ToString("G", en));
            Console.WriteLine("Brasil: " + valor.ToString("G", br));
            Console.WriteLine("Espanha: " + valor.ToString("G", es));

            // =================================== //

            Console.WriteLine("\n===============\n");

            Console.WriteLine("NÚMEROS(N):");
            Console.WriteLine("EUA: " + valor.ToString("N", en));
            Console.WriteLine("Brasil: " + valor.ToString("N", br));
            Console.WriteLine("Espanha: " + valor.ToString("N", es));

            // =================================== //

            Console.WriteLine("\n===============\n");

            Console.WriteLine("PORCENTAGEM(P):");

            decimal porc1 = 0.1m;
            int porc2 = 1;
            decimal porc3 = 0.35m;

            Console.WriteLine(porc1.ToString("P"));
            Console.WriteLine(porc2.ToString("P"));
            Console.WriteLine(porc3.ToString("P"));

            // =================================== //

            Console.WriteLine("\n===============\n");

            Console.WriteLine("MÉTODO MATH:\n");

            decimal num = 101.75m;
            Console.WriteLine("Número escolhido: " + num);

            Console.WriteLine(
                "\nArredondando: " +
                Math.Round(num)
                );

            Console.WriteLine(
                "Arredondando para cima: " +
                Math.Ceiling(num)
                );

            Console.WriteLine(
                "Arredondando para baixo: " +
                Math.Floor(num)
                );

            Console.WriteLine(
                "Remover casas decimais: " +
                Math.Truncate(num)
                );

            decimal num1 = -8;
            Console.WriteLine("\n\nNúmero escolhido: " + num1);

            Console.WriteLine(
                "Absoluto: " +
                Math.Abs(num1) + "\n"
            );



        }
    }
}
