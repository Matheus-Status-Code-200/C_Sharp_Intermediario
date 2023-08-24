using System;

class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Salario { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Dados do Funcionário:");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Salário: R${Salario}");
    }
}

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nCadastro de Funcionário");
        Console.WriteLine("------------------------\n");
        Console.WriteLine("Neste programa, você pode cadastrar um funcionário.\n");
        Console.ResetColor();

        Funcionario funcionario = new Funcionario();

        Console.Write("Digite o nome do funcionário: ");
        funcionario.Nome = Console.ReadLine();

        Console.Write("Digite a idade do funcionário: ");
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            funcionario.Idade = idade;
        }
        else
        {
            Console.WriteLine("Idade inválida. Usando valor padrão (25).");
            funcionario.Idade = 25;
        }

        Console.Write("Digite o salário do funcionário: ");
        if (double.TryParse(Console.ReadLine(), out double salario))
        {
            funcionario.Salario = salario;
        }
        else
        {
            Console.WriteLine("Salário inválido. Usando valor padrão (1500.00).");
            funcionario.Salario = 1500.00;
        }

        Console.WriteLine();
        funcionario.ExibirDados();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMais Projetos e Exemplos em: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
