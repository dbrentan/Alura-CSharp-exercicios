using System;

namespace ByteBankParteTres.src.Entities
{
    class Program
    {
        static void Main (string[] args)
        {
            Cliente gabriela = new Cliente();
            
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "333.444-5";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 56344;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
        }
    }
}