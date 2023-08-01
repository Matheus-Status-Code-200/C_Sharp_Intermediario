using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Exemplo de Lambda em C#");
        Console.WriteLine("-----------------------\n");
        Console.WriteLine("Nesse programa, utilizamos lambda expressions para criar funções anônimas.\n");
         Console.WriteLine("Usamos Action para pegar um valor digitado na função lambida.\n");

        Action<string> getName = name => Console.WriteLine($"Olá {name}");


        Console.Write("Digite seu nome: ");
        var addName = Console.ReadLine();
        getName(addName);

        Func<string, bool> checkedName = name => string.Equals(name, "Matheus", StringComparison.OrdinalIgnoreCase);

        Console.WriteLine(checkedName(addName)+"\n");

        var multiplicacao = (double x, double y) => x * y;
        double num1 = 20;
        double num2 = 30;
        double resultado = multiplicacao(num1, num2);

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Resultado da Multiplicação de {num1} por {num2}: {resultado}");

        Console.WriteLine("\nMais Projetos: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
