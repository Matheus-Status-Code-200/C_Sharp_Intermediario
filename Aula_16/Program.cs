using System;

namespace ExemploNamespace
{
    static class MyExtensions
    {
        public static int Square(this int number)
        {
            return number * number;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nPrograma 3 - Usando Extensions Methods de Terceiros");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Você também pode usar Extensions Methods de bibliotecas de terceiros.");
            Console.WriteLine("Esses métodos estendem as funcionalidades das classes já existentes.");
            Console.WriteLine("Aqui, criamos um Extension Method chamado 'Square' para a classe 'int'.");
            Console.WriteLine("Isso permite calcular o quadrado de um número inteiro de maneira mais simples.\n");

            int numero = 5;
            int quadrado = numero.Square();
            Console.WriteLine($"O quadrado de {numero} é {quadrado}.");

            Console.WriteLine("\nMais Projetos em: https://github.com/Matheus-Status-Code-200\n");
        }
    }
}
