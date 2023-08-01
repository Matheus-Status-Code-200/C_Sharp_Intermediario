using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Exemplo de Delegate em C#");
        Console.WriteLine("-------------------------\n");
        Console.WriteLine("Nesse programa, usamos delegate para criar uma função anônima que recebe");
        Console.WriteLine("um nome como entrada e imprime uma saudação. Também usamos delegate para");
        Console.WriteLine("verificar se o nome fornecido é 'Matheus', ignorando a sensibilidade de letras.\n");

        var getName = delegate(string name)
        {
            Console.WriteLine($"Olá {name}");
        };

        Console.Write("Digite seu nome: ");
        var addName = Console.ReadLine();
        getName(addName);

        Func<string, bool> checkedName = delegate(string name)
        {
            return string.Equals(name, "Matheus", StringComparison.OrdinalIgnoreCase);
        };

        Console.WriteLine(checkedName(addName));

        Console.WriteLine("\nMais Projetos: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
