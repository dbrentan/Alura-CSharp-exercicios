using System;

namespace CondicionaisDois
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 18;
            // int quantidadePessoas = 2;

            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {   
                Console.WriteLine("Não pode entrar");
    
            }

            int idadePedro = 16;
           
            bool acompanhadoPedro = true;

            if (idadePedro >= 18 || acompanhadoPedro == true)
            {
                Console.WriteLine("Pedro pode entrar");
            }
            else
            {
                Console.WriteLine("Pedro Não pode entrar");
            }

        }
    }
}