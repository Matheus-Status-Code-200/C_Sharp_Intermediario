using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        List<string> lista = new List<string> { "matheus", "200",""};

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nTratamento de exceção");
        Console.WriteLine("-----------------------------------\n");
        Console.WriteLine("Este programa trata os erros gerados.");
        Console.WriteLine("Cada interação na lista gera uma erro diferente que será tratado em cada Catch respectivo ao erro.\n");

        for (int i = 0; i < lista.Count+1; i++)
        {
            try
            {
                 Console.ForegroundColor = ConsoleColor.Green;
                // Tentar obter o comprimento da string
                Console.WriteLine($"Comprimento do elemento {i}: {lista[i].Length}");

                // Tentar converter o elemento para inteiro
                int numero = int.Parse(lista[i]);
                Console.WriteLine($"Elemento {i} convertido para inteiro: {numero}\n");
            }
            catch (NullReferenceException exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"Erro: {exception.Message}.\n");
                Console.ResetColor();
            }
            catch (FormatException exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"Erro de formato: {exception.Message}.\n");
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"Erro de Index: {exception.Message}.\n");
                Console.ResetColor();
            }
        }Console.ResetColor();
    }
}
