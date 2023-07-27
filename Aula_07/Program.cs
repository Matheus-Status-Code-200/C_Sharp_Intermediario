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

        string[]? linhas = null; // Declara a variável fora do escopo do try
        
        // Obter o diretório atual em que o programa está rodando
        string diretorioAtual = Environment.CurrentDirectory;

        // Nome do arquivo que será criado
        string nomeArquivo = "arquivo.txt";

        // Combinar o caminho do diretório atual com o nome do arquivo
        string caminhoArquivo = Path.Combine(diretorioAtual, nomeArquivo);

        try
        {
            // Verificar se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                // Ler todas as linhas do arquivo
                linhas = File.ReadAllLines(caminhoArquivo);

                // Obter o valor da última linha
                if (linhas.Length > 0)
                {
                    // Separar o número da linha do conteúdo
                    string[] ultimaLinhaSeparada = linhas[linhas.Length - 1].Split(' ');
                    int ultimaLinha = int.Parse(ultimaLinhaSeparada[0]) + 1;

                    // Conteúdo do arquivo
                    string conteudo = "Este é um arquivo de texto criado com C#.";

                    // Gravar o novo conteúdo no arquivo, incluindo o número da próxima linha
                    File.AppendAllText(caminhoArquivo, $"{ultimaLinha} - {conteudo}{Environment.NewLine}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Arquivo '{nomeArquivo}' criado com sucesso no diretório: {diretorioAtual}");
                    Console.ResetColor();
                }
                else
                {
                    // Caso o arquivo não exista, cria o arquivo e escreve o conteúdo inicial com o número da primeira linha sendo 1
                    File.WriteAllText(caminhoArquivo, "1 - Este é um arquivo de texto criado com C#." + Environment.NewLine);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Arquivo '{nomeArquivo}' criado com sucesso no diretório: {diretorioAtual}");
                    Console.ResetColor();
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro ao criar o arquivo: {ex.Message}");
            Console.ResetColor();
        }
        finally
        {
            if (linhas != null)
            {
                Console.WriteLine("\nDeseja ver o conteúdo do arquivo? (sim/não): ");
                string resposta = Console.ReadLine() ?? "não";
                resposta = resposta.ToLower();
                if (resposta == "sim" || resposta == "s")
                {
                    // Ler novamente o arquivo após a gravação
                    linhas = File.ReadAllLines(caminhoArquivo);

                    // Exibir o conteúdo atualizado do arquivo na tela
                    Console.WriteLine("\nConteúdo do arquivo:");
                    foreach (var linha in linhas)
                    {
                        Console.WriteLine(linha);
                    }
                }else{
                    Console.WriteLine("Fim....");
                }

            }
        }
    }
}
