using System;

namespace CalculaPaupanca
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            // 0.36% = 0.0036
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                if (contadorMes == 1)
                {
                    Console.WriteLine($"Após {contadorMes} mês, você terá R${valorInvestido}");
                }
                else
                {
                    Console.WriteLine($"Após {contadorMes} meses, você terá R${valorInvestido}");
                }

                contadorMes++;

            }

        }
    }
}