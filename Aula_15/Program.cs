using System;

namespace ExemploNamespace
{
    static class StringExtensions
    {
        public static string FirstLetterToUpper(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input[1..];
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nPrograma 2 - Extensions Methods");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Um Extension Method é um método estático que adicionamos a uma classe existente.");
            Console.WriteLine("Isso permite estender funcionalidades de classes sem modificar o código original.");
            Console.WriteLine("Aqui, criamos um Extension Method chamado 'FirstLetterToUpper' para a classe 'string'.");
            Console.WriteLine("Isso converte a primeira letra da string para maiúscula.\n");
            
            string texto = "hello world";
            string textoComPrimeiraLetraMaiuscula = texto.FirstLetterToUpper();
            Console.WriteLine($"Texto original: {texto}");
            Console.WriteLine($"Texto com a primeira letra maiúscula: {textoComPrimeiraLetraMaiuscula}");
        }
    }
}
