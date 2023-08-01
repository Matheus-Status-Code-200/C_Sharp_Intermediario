using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Cálculo de Multiplicação usando Delegate");
        Console.WriteLine("----------------------------------------\n");
        Console.WriteLine("Nesse programa, usamos delegate para realizar a operação de multiplicação.");
        Console.WriteLine("O delegate é uma referência a uma função anônima que executa a multiplicação de dois números.\n");

        var multiplicacao = delegate(double x, double y) { return x * y; };
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
