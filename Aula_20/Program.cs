using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Execução de Tarefas em Fila");
        Console.WriteLine("-----------------------------------\n");
        Console.WriteLine("Neste programa, demonstramos o uso de uma fila para executar tarefas sequencialmente.");
        Console.WriteLine("Cada tarefa é enfileirada, executada e aguarda um atraso antes de prosseguir para a próxima tarefa.\n");
        Console.ResetColor();

        Queue<Action> filaTarefas = new Queue<Action>();

        // Adicionando tarefas à fila
        filaTarefas.Enqueue(() => Console.WriteLine("Tarefa 1 executada"));
        filaTarefas.Enqueue(() => Console.WriteLine("Tarefa 2 executada"));
        filaTarefas.Enqueue(() => Console.WriteLine("Tarefa 3 executada"));

        Console.WriteLine("Tarefas enfileiradas:");
        foreach (var tarefa in filaTarefas)
        {
            tarefa(); // Executa cada tarefa da fila
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPressione Enter para executar a próxima tarefa...");
        Console.ResetColor();
        Console.ReadLine();

        while (filaTarefas.Count > 0)
        {
            Action tarefaAtual = filaTarefas.Dequeue();
            Console.WriteLine("\nExecutando a próxima tarefa:");
            tarefaAtual();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPressione Enter para executar a próxima tarefa...");
            Console.ResetColor();
            Console.ReadLine();

            await Task.Delay(1000); // Aguarda 1 segundo entre as tarefas
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Todos as tarefas foram concluidas.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nMais Projetos e Exemplos em: {GetGitHubLink()}\n");
        Console.ResetColor();
    }

    static string GetGitHubLink()
    {
        return "https://github.com/Matheus-Status-Code-200";
    }
}
