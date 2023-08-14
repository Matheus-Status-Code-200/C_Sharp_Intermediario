using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Desfazendo Ações com Pilha");
        Console.WriteLine("---------------------------\n");
        Console.WriteLine("Nesse programa, implementamos uma funcionalidade de 'desfazer' ações usando pilha.\n");
        Console.ResetColor();

        Stack<string> acoes = new Stack<string>();
        string pararPrograma;
        bool runCode = true;

        while (runCode)
        {
            Console.Write("Digite uma ação (ou d 'desfazer' para reverter a última ação): ");
            string? acao = Console.ReadLine();

            if (acao != null)
            {
                if (acao.ToLower() == "desfazer" || acao.ToLower() == "d")
                {
                    if (acoes.Count > 0)
                    {
                        string acaoDesfeita = acoes.Pop();
                        Console.WriteLine($"Ação desfeita: {acaoDesfeita}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma ação para desfazer.");
                        Console.WriteLine("Deseja sair? (s / n)");
                        pararPrograma = Console.ReadLine();

                        if (pararPrograma == "s")
                        {
                            runCode = false;
                        }
                    }
                }
                else
                {
                    acoes.Push(acao);
                }
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nMais Projetos e Exemplos em: {GetGitHubLink()}\n");
        Console.ResetColor();
    }

    static string GetGitHubLink()
    {
        return "https://github.com/Matheus-Status-Code-200";
    }
}
