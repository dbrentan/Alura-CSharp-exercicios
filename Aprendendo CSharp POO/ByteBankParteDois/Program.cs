using System;

namespace ByteBankParteDois
{
    class Program
    {
        static void Main (string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine($"Seu saldo atual é de: {contaDoBruno.saldo}");

            bool resultado = contaDoBruno.Sacar(50);

            Console.WriteLine($"Seu saldo atual é de: {contaDoBruno.saldo}");
            Console.WriteLine(resultado);

        }
    }
}