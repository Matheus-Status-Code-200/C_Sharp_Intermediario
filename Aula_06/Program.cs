using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Criação de Arquivo de Texto");
        Console.WriteLine("--------------------------------\n");
        Console.WriteLine("Este programa cria um arquivo de texto no diretório em que está sendo executado.");
        Console.WriteLine("O nome do arquivo será 'arquivo.txt' e o conteúdo será 'Este é um arquivo de texto criado com C#.'");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        try
        {
            // Obter o diretório atual em que o programa está rodando
            string diretorioAtual = Environment.CurrentDirectory;

            // Nome do arquivo que será criado
            string nomeArquivo = "arquivo.txt";

            // Conteúdo do arquivo
            string conteudo = "Este é um arquivo de texto criado com C#.";

            // Combinar o caminho do diretório atual com o nome do arquivo
            string caminhoArquivo = Path.Combine(diretorioAtual, nomeArquivo);

            // Cria o arquivo e escreve o conteúdo nele
            File.AppendAllText(caminhoArquivo, $"{conteudo}{Environment.NewLine}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Arquivo '{nomeArquivo}' criado com sucesso no diretório: {diretorioAtual}");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro ao criar o arquivo: {ex.Message}");
            Console.ResetColor();
        }
    }
}
