using System;

namespace ExemploNamespace
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cálculo de Quadrados Perfeitos");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Este programa calcula quantos quadrados perfeitos");
            Console.WriteLine("iniciando do menor para o maior, cabem em um número passado sem repetir\n");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite um número inteiro positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
            {
                ExibirQuadradosPerfeitos(numero);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Digite um número inteiro positivo maior que zero.");
                Console.ResetColor();
            }
        }

        static void ExibirQuadradosPerfeitos(int numero)
        {
            Console.WriteLine($"\nNúmero informado: {numero}");
            Console.WriteLine("\nQuadrados perfeitos formados:");

            int lado = 1;
            int quadradosPerfeitos = 0;
            int somaQuadrados = 0;

            while (somaQuadrados + (lado * lado) <= numero)
            {
                somaQuadrados += lado * lado;
                Console.WriteLine($"Quadrado perfeito - {lado}x{lado} = {lado * lado} unidade(s)");
                quadradosPerfeitos++;
                lado++;
            }

            int resto = numero - somaQuadrados;
            Console.WriteLine($"\nRestam {resto} unidade(s).");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTotal de quadrados perfeitos formados: {quadradosPerfeitos}");
            Console.WriteLine("\nMais Projetos em: https://github.com/Matheus-Status-Code-200\n");
            Console.ResetColor();
        }
    }
}

