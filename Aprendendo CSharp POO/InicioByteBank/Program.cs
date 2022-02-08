using System;
using InicioByteBank;

namespace InicioByteBanl
{
    class Program
    {
        static void Main (string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine($"Nome Titular: {contaDaGabriela.titular}");
            Console.WriteLine($"Agência: {contaDaGabriela.agencia}");
            Console.WriteLine($"Número: {contaDaGabriela.numero}");
            Console.WriteLine($"Saldo em conta: {contaDaGabriela.saldo}");
        }
    }
}