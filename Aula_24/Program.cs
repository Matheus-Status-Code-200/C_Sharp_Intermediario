using System;

class Program
{
    class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("O animal emitiu um som.");
        }
    }

    class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine("O cachorro está latindo.");
        }
    }

    class Gato : Animal
    {
        public void Miar()
        {
            Console.WriteLine("O gato está miando.");
        }
    }

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Programa de Demonstração de POO");
        Console.WriteLine("--------------------------------\n");
        Console.WriteLine("Neste programa, ilustramos alguns conceitos de Programação Orientada a Objetos.\n");
        Console.ResetColor();

        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Rex";
        cachorro.Idade = 3;

        Gato gato = new Gato();
        gato.Nome = "Miau";
        gato.Idade = 2;

        Console.WriteLine($"Cachorro: {cachorro.Nome}, {cachorro.Idade} anos");
        cachorro.Latir();
        cachorro.EmitirSom();

        Console.WriteLine($"\nGato: {gato.Nome}, {gato.Idade} anos");
        gato.Miar();
        gato.EmitirSom();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMais Projetos e Exemplos em: https://github.com/Matheus-Status-Code-200\n");
        Console.ResetColor();
    }
}
