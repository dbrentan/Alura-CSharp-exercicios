using System;

namespace ByteBankParteSeis.src.Entities
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(876, 888777);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaDaGabriela = new ContaCorrente(876, 888777);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}