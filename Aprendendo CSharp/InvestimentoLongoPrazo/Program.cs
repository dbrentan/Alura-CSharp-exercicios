using System;

namespace InvestimentoLongoPtrazo
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calculando investimento Longo Prazo - Laço Encadeado");
            Console.WriteLine();

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <=5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;

                if (contadorAno == 1)
                {
                    Console.WriteLine($"Ao término de {contadorAno} ano, você terá R${valorInvestido.ToString("0.00")}");
                }
                
                if (contadorAno > 1 && contadorAno < 5)
                {
                    Console.WriteLine($"Ao término de {contadorAno} anos, você terá R${valorInvestido.ToString("0.00")}");
                }
            }

            Console.WriteLine($"Ao término do investimento, você terá R${valorInvestido.ToString("0.00")}");
        }
    }
}