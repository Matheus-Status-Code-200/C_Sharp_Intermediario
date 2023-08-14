using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Inversão de Palavra com Pilha");
        Console.WriteLine("-----------------------------\n");
        Console.WriteLine("Nesse programa, invertemos a ordem das letras de uma palavra usando uma pilha.\n");
        Console.ResetColor();

        Console.Write("Digite uma palavra: ");
        string? palavra = Console.ReadLine();

        if (palavra != null)
        {
            Stack<char> pilha = new Stack<char>();
            foreach (char letra in palavra)
            {
                pilha.Push(letra);
            }

            Console.Write("\nPalavra invertida: ");
            while (pilha.Count > 0)
            {
                Console.Write(pilha.Pop());
            }
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
