using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nProps get e set e Interface.");
        Console.WriteLine("-----------------------------------\n");
        Console.WriteLine("Este programa é uma continuação da Aula 03 e 04.");
        Console.WriteLine("Aqui foi adicionado a interface.\n");

        try{
            ConsoleLoggeer logger = new ConsoleLoggeer();
            Bankacount acount1 = new Bankacount( "Matheus", 100, logger);
            Bankacount acount2 = new Bankacount("Dev", 100, logger);
            //Exibir saldo após operações
            acount1.Deposit(100);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nA conta pretencente a {acount1.GetName()} tem R$:{acount1.Balance}\n");
            Console.ResetColor();

            acount2.Deposit(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nA conta pretencente a {acount2.GetName()} tem R$:{acount2.Balance}\n");
            Console.ResetColor();

        }catch(Exception exception){
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro: {exception}");
            Console.ResetColor();
        }

    }
    class ConsoleLoggeer : Ilogger
    {
        public void Log(string message)
        {
            Console.Write($"LOGGER: {message} ");
        }
    }

    /* É um tipo não concreto, ele implementa os contratos*/
    interface Ilogger{
void Log(string message);
    }
   class Bankacount{
    private string name;
    private readonly Ilogger logger;
    public decimal Balance{
        /* 
        Somente a classe pode agora passar um valor para balance pois o metodo set é privado, o que o protege
        de ser manipulado por um elemento fora da classe.
        */
        get;
        private set;
    }

    public Bankacount(string name, decimal balance, Ilogger logger){
        this.name = name;
        Balance = balance;
        this.logger=logger;


        if(string.IsNullOrWhiteSpace(name)){
            Console.ForegroundColor = ConsoleColor.Red;
            throw new ArgumentException("Nome não pode ser vazio ou nulo.",nameof(name));
        }
        if (Balance <= 0){
            Console.ForegroundColor = ConsoleColor.Red;
            throw new Exception("Tipo de deposito invalido!");
        }


        Console.ResetColor();
    }
    public void Deposit(decimal valor){
        if(valor<=0){
            return;
        }
        logger.Log("Deposito feito com sucesso.");
        Balance += valor;
    }
    
    public string GetName(){
        return name;
    }
   }
}
