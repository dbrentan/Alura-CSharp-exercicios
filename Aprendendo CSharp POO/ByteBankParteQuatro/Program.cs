using System;

namespace ByteBankParteQuatro.src.Entities
{
    class Program
    {
        static void Main (string[] args)
        {
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();
            contaDaCamila.titular.nome = "Camila Correia";
            contaDaCamila.titular.cpf = "333.333.66";
            

            Console.WriteLine(contaDaCamila.titular.nome);
            Console.WriteLine(contaDaCamila.titular.cpf);
            Console.WriteLine(contaDaCamila.saldo);

        }
    }
}