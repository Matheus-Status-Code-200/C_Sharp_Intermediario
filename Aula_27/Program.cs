using System;

// Classe base Funcionário
class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double SalarioBase { get; set; }

    // Construtor
    public Funcionario(string nome, int idade, double salarioBase)
    {
        Nome = nome;
        Idade = idade;
        SalarioBase = salarioBase;
    }

    // Método para calcular o salário
    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}

// Classe Horista, subclasse de Funcionário
class Horista : Funcionario
{
    public int HorasTrabalhadas { get; set; }

    // Construtor
    public Horista(string nome, int idade, double salarioBase, int horasTrabalhadas)
        : base(nome, idade, salarioBase)
    {
        HorasTrabalhadas = horasTrabalhadas;
    }

    // Método para calcular o salário do funcionário horista
    public override double CalcularSalario()
    {
        return SalarioBase * HorasTrabalhadas;
    }
}

// Classe Mensalista, subclasse de Funcionário
class Mensalista : Funcionario
{
    public int DiasTrabalhados { get; set; }

    // Construtor
    public Mensalista(string nome, int idade, double salarioBase, int diasTrabalhados)
        : base(nome, idade, salarioBase)
    {
        DiasTrabalhados = diasTrabalhados;
    }

    // Método para calcular o salário do funcionário mensalista
    public override double CalcularSalario()
    {
        return SalarioBase * DiasTrabalhados;
    }
}

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nExemplo de Herança e Polimorfismo - Cálculo de Salário");
        Console.WriteLine("------------------------------------------------------\n");
        Console.WriteLine("Neste programa, usamos herança e polimorfismo para calcular salários de funcionários.\n");
        Console.ResetColor();

        Horista horista = new Horista("Matheus", 25, 10.0, 40);
        Mensalista mensalista = new Mensalista("Dev", 30, 2000.0, 22);

        Console.WriteLine($"Salário do funcionário {horista.Nome} horista: " + horista.CalcularSalario());
        Console.WriteLine($"Salário do funcionário {mensalista.Nome} mensalista: " + mensalista.CalcularSalario());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMais Projetos e Exemplos em: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
