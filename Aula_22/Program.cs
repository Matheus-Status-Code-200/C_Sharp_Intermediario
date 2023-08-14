using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Conversão de Decimal para Binário com Pilha");
        Console.WriteLine("------------------------------------------\n");
        Console.WriteLine("Nesse programa, convertemos um número decimal para binário usando pilha.\n");
        Console.ResetColor();

        Console.Write("Digite um número decimal: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int numeroDecimal))
        {
            Stack<int> pilha = new Stack<int>();
            while (numeroDecimal > 0)
            {
                pilha.Push(numeroDecimal % 2);
                numeroDecimal /= 2;
            }

            Console.Write("\nRepresentação binária: ");
            while (pilha.Count > 0)
            {
                Console.Write(pilha.Pop());
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada inválida. Digite um número decimal válido.");
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n\nMais Projetos e Exemplos em: {GetGitHubLink()}\n");
        Console.ResetColor();
    }

    static string GetGitHubLink()
    {
        return "https://github.com/Matheus-Status-Code-200";
    }
}
