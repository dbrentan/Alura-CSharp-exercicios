using System;

namespace MultiploDeTres
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Os Múltiplos de 3 são:");

            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}