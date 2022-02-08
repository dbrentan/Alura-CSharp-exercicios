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

            bool resultado = contaDoBruno.Sacar(500);

            if (resultado == false)
                {
                    Console.WriteLine($" Acão tomada: {resultado}");
                }

            Console.WriteLine($"Seu saldo atual é de: {contaDoBruno.saldo}");

            contaDoBruno.Depositar (500);

            Console.WriteLine($"Saldo em conta é de: {contaDoBruno.saldo}");

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Transferir(300, contaDaGabriela);

            Console.WriteLine($"Saldo atual do bruno: {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo Atual da Gabriela: {contaDaGabriela.saldo}");
        }
    }
}