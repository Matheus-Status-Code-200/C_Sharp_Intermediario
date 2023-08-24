using System;

class Carro
{
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int NumeroPortas { get; set; }
    public string TipoMotor { get; set; }
    public string TipoCambio { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Detalhes do Carro:");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Número de Portas: {NumeroPortas}");
        Console.WriteLine($"Tipo de Motor: {TipoMotor}");
        Console.WriteLine($"Tipo de Câmbio: {TipoCambio}");
    }
}

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Programa de Detalhes de Carro");
        Console.WriteLine("-----------------------------\n");
        Console.WriteLine("Neste programa, você pode informar os detalhes de um carro.\n");
        Console.ResetColor();

        Carro carro = new Carro();

        Console.Write("Digite o modelo do carro (Modelo 1, Modelo 2, Modelo 3): ");
        carro.Modelo = Console.ReadLine();

        Console.Write("Digite a cor do carro: ");
        carro.Cor = Console.ReadLine();

        Console.Write("Digite o número de portas do carro: ");
        if (int.TryParse(Console.ReadLine(), out int numeroPortas))
        {
            carro.NumeroPortas = numeroPortas;
        }
        else
        {
            Console.WriteLine("Número de portas inválido. Usando valor padrão (4).");
            carro.NumeroPortas = 4;
        }

        Console.Write("Digite o tipo de motor do carro: ");
        carro.TipoMotor = Console.ReadLine();

        Console.Write("Digite o tipo de câmbio do carro: ");
        carro.TipoCambio = Console.ReadLine();

        Console.WriteLine();
        carro.ExibirDetalhes();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMais Projetos e Exemplos em: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
