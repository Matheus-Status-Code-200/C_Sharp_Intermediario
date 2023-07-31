using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Programa de Tipagem Implícita e Delegate");
        Console.WriteLine("---------------------------------------\n");
        Console.WriteLine("Nesse programa usamos a tipagem de maneira implícita e delegate.");
        Console.WriteLine("Assim declaramos apenas o 'var', o nome e o valor da variável, e o compilador definirá o tipo.\n");
        Console.ResetColor();

        var numero1 = 10;
        var numero2 = 20;
        var numdouble = 1.223;
        var stringimplicita = "Matheus";
        var calculo = new Calculo(Soma);
        var resultado = calculo(numero1, numero2);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("O Resultado da soma é: " + resultado);
        

        Console.WriteLine("\nProjetos: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }

    static int Soma(int num1, int num2)
    {
        return num1 + num2;
    }

    delegate int Calculo(int a, int b);
}
