using System;
using System.Globalization;

namespace Curso
{
    public static class Data
    {
        public static void Show()
        {

            // =================================== //

            Console.Clear();

            var data = DateTime.Now; //Pegar Data e Hora atual
            Console.WriteLine("DateTime.Now + DayOfWeek:");
            Console.WriteLine(data);
            Console.WriteLine(data.DayOfWeek); //Mostra o dia da semana da data inserida

            // =================================== //


            Console.WriteLine("\nFORMATANDO DATAS:");

            //var formato = String.Format("{0:y}\n", data);  // mês + ano
            //var formato = String.Format("{0:M}\n", data);  // dia + mês
            //var formato = String.Format("{0:yyyy-MM-dd}\n", data);  // ano + mês + dia (pode trocar posição)
            //var formato = String.Format("{0:mm}\n", data);  // MINUTOS
            //var formato = String.Format("{0:hh:mm:ss}\n", data);  // horas, minutos e segundos
            //var formato = String.Format("{0:t}\n", data);  // T = horas, minutos e segundos / t = horas e minutos
            //var formato = String.Format("{0:D}\n", data);  // dia da semana, dia, mês, ano
            //var formato = String.Format("{0:f}\n", data); // igual o de cima + horas e minutos
            var formato = String.Format("{0:r}\n", data); // MAIORIA DOS SISTEMAS USAM - Semana, dia, mês, ano, hora, minutos, segundos e time zone

            Console.WriteLine(formato);

            // =================================== //


            Console.WriteLine("ADICIONANDO VALORES:");

            Console.WriteLine("Daqui 15 dias será: " + data.AddDays(15));

            Console.WriteLine("15 Dias atrás era: " + data.AddDays(-15));

            Console.WriteLine("Daqui 1 mês será: " + data.AddMonths(1));

            Console.WriteLine("Daqui 2 anos será: " + data.AddYears(2));

            Console.WriteLine("Daqui 2 horas será: " + data.AddHours(2) + "\n");

            // =================================== //


            Console.WriteLine("COMPARANDO DATAS:");

            var data2 = new DateTime(2025, 4, 3); // "03/04/2025"

            if (data2.Date == DateTime.Now.Date) //Comparando se "data2" (acima) é igual a data que este programa está sendo rodado
            {
                Console.WriteLine("A data é igual.\n");
            }
            if (data2.Date < DateTime.Now.Date)
            {
                Console.WriteLine("Data inserida ja passou!\n");
            }
            if (data2.Date > DateTime.Now.Date)
            {
                Console.WriteLine("Data inserida nem chegou ainda!\n");
            }

            // =================================== //

            Console.WriteLine("CultureInfo:");

            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            Console.WriteLine("BRASIL: " + data.ToString("D", br)); // "D" - Aula de formatação (acima)
            Console.WriteLine("EUA: " + data.ToString("D", en));
            Console.WriteLine("DINAMARCA: " + data.ToString("D", de) + "\n");

        }
    }
}
