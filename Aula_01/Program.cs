using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        string nome = null;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nTratamento de exceção");
        Console.WriteLine("--------------------------------\n");
        Console.WriteLine("Este programa trata o erro gerado por uma string vazia gerando uma exceção.");
        Console.WriteLine("Também algumas opções do System no terminal são modificadas.\n");
        try
        {
            Console.WriteLine(nome.Length);
        }
        catch (System.NullReferenceException)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Muda a cor do texto para vermelho
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Error.WriteLine($"Erro: A variável 'nome' não pode ser nula.\n");
            Console.ResetColor(); // Volta à cor padrão dos textos

            // Aqui você pode adicionar outros tratamentos ou ações caso ocorra a exceção
        }
    }
}
