using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Implementação de Fila Simples");
        Console.WriteLine("-----------------------------------\n");
        Console.WriteLine("Nesse programa, demonstramos como usar uma fila simples usando uma collection.\n");
        Console.ResetColor();

        Queue<string> fila = new Queue<string>();

        fila.Enqueue("João");
        fila.Enqueue("Maria");
        fila.Enqueue("Pedro");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Fila:");
        Console.ResetColor();
        foreach (string pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }

        Console.WriteLine($"\nPróximo a ser atendido: {fila.Dequeue()}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMais Projetos em: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
