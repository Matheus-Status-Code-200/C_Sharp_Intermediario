using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nTratamento de exceção");
        Console.WriteLine("-----------------------------------\n");
        Console.WriteLine("Este programa usa classes trata os erros gerados.");
        Console.WriteLine("Simulação de deposito bancário.\n");

        try{
            Bankacount acount1 = new Bankacount( "Matheus", 100);
            Bankacount acount2 = new Bankacount("Dev", 100);
            //Exibir saldo após operações
            acount1.Deposit(100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nA conta pretencente a {acount1.GetName()} tem R$:{acount1.GetBalance()}\n");
            Console.ResetColor();

            acount2.Deposit(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nA conta pretencente a {acount2.GetName()} tem R$:{acount2.GetBalance()}");
            Console.ResetColor();

        }catch(Exception exception){
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro: {exception}");
            Console.ResetColor();
        }

    }
   class Bankacount{
    private string name;
    private decimal balance;

    public Bankacount(string name, decimal balance){
        this.name = name;
        this.balance = balance;
        if(string.IsNullOrWhiteSpace(name)){
            Console.ForegroundColor = ConsoleColor.Red;
            throw new ArgumentException("Nome não pode ser vazio ou nulo.",nameof(name));
        }
        if (this.balance <= 0){
            Console.WriteLine("Depositar: "+this.balance);
            Console.ForegroundColor = ConsoleColor.Red;
            throw new Exception("Tipo de deposito invalido!");
        }

        Console.ResetColor();
    }
    public void Deposit(decimal valor){
        if(valor<=0){
            return;
        }
        balance += valor;
    }
    public decimal GetBalance(){
        return balance;
    }
    public string GetName(){
        return name;
    }
   }
}
