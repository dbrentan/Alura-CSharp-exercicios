using System;

namespace ByteBankParteCinco.src.Entities
{
    class Program
    {
        static void Main (string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "555.666.77";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine($"Nome do Cliente: {conta.Titular.Nome}");
            Console.WriteLine($"CPF: {conta.Titular.CPF}");
            Console.WriteLine($"Profissão: {conta.Titular.Profissao}");
            Console.WriteLine($"Saldo em Conta: {conta.Saldo}");
        }
    }
}
