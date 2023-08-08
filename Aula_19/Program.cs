using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Simulação de Atendimento de Fila");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Nesse programa, simulamos o atendimento de uma fila em um painel eletronico.\n");
        Console.ResetColor();

        Queue<string> filaAtendimento = new Queue<string>();

        filaAtendimento.Enqueue("Cliente A");
        filaAtendimento.Enqueue("Cliente B");
        filaAtendimento.Enqueue("Cliente C");

        Console.WriteLine("Pressione Enter para chamar o próximo cliente...");

        while (filaAtendimento.Count > 0)
        {   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadLine();
            string clienteAtual = filaAtendimento.Dequeue();
            Console.WriteLine($"Atendendo: {clienteAtual}");

            if (filaAtendimento.Count > 0)
            {
                Console.WriteLine("Pressione Enter para chamar o próximo cliente...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Todos os clientes foram atendidos.");
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMais Projetos em: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
