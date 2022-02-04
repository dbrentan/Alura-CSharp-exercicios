using System;

namespace CaracteresETextos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine($"Imprimindo o Caractere: {primeiraLetra}");

            primeiraLetra = (char)61;
            Console.WriteLine($"Imprimindo o Caractere: {primeiraLetra}");

            primeiraLetra = (char)(primeiraLetra +1);
            Console.WriteLine($"Imprimindo o Caractere: {primeiraLetra}");

            string titulo = "Alura Crusos de tecnologia " + 2022;
            Console.WriteLine($"Usando uma string: {titulo}");

            string programacao = @"
- .NET
- Java
- JavaScript";

            Console.WriteLine($"Usando o @ para quebra de linhas Exemplo: {programacao}");

        }
    }
}