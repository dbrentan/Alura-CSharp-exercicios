using System;

namespace Escopo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == false)
            {
                mensagemAdicional = "João está Acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João pode entrar");
                 Console.WriteLine(mensagemAdicional);
            }
            else
            {   
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(mensagemAdicional);
    
            }

        }
    }
}