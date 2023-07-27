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
        Console.WriteLine("O nome do arquivo será 'arquivo.txt' e o conteúdo será digitado pelo usuário.");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        string[] linhas = null;
        // Obter o diretório atual em que o programa está rodando
        string diretorioAtual = Environment.CurrentDirectory;

        // Nome do arquivo que será criado
        string nomeArquivo = "arquivo.txt";

        // Combinar o caminho do diretório atual com o nome do arquivo
        string caminhoArquivo = Path.Combine(diretorioAtual, nomeArquivo);

        int numeroLinha = 1; // Contador para o número da linha

        try
        {
            // Verificar se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                // Ler todas as linhas do arquivo
                linhas = File.ReadAllLines(caminhoArquivo);

                // Obter o número da última linha no arquivo
                if (linhas.Length > 0)
                {
                    string[] ultimaLinhaSeparada = linhas[linhas.Length - 1].Split('-');
                    numeroLinha = int.Parse(ultimaLinhaSeparada[0].Trim()) + 1;
                }
            }

            // Solicitar ao usuário o conteúdo a ser gravado no arquivo
            Console.Write("Digite o conteúdo a ser gravado no arquivo: ");
            string conteudoUsuario = Console.ReadLine();

            // Montar o conteúdo final a ser gravado no arquivo, incluindo o número da linha e a data e hora da gravação
            string conteudoFinal = $"{numeroLinha} - {conteudoUsuario} - {DateTime.Now}";

            // Gravar o conteúdo no arquivo, incluindo uma quebra de linha para separar do conteúdo anterior (caso exista)
            File.AppendAllText(caminhoArquivo, $"{conteudoFinal}{Environment.NewLine}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Arquivo '{nomeArquivo}' criado/atualizado com sucesso no diretório: {diretorioAtual}");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro ao criar/atualizar o arquivo: {ex.Message}");
            Console.ResetColor();
        }
        finally
        {
            if (linhas != null)
            {
                Console.WriteLine("\nDeseja ver o conteúdo do arquivo? (sim/não): ");
                string resposta = Console.ReadLine().ToLower();
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
                }
            }
        }
    }
}
