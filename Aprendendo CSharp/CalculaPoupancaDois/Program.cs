using System;

namespace CalculaPoupancaDois
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Executando projeto 11: Usando o laço For");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;  //Juros por mês

                if (contadorMes == 1)
                {
                    Console.WriteLine($"Após {contadorMes} mês, você terá R${valorInvestido.ToString("0.00")}");
                }
                else
                {
                    Console.WriteLine($"Após {contadorMes} meses, você terá R${valorInvestido.ToString("0.00")}");
                }
            }

        }
    }
}