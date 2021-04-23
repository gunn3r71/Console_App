using System;
using System.IO;
using System.Configuration;

namespace Pastas
{
    class Arquivo
    {
        private static string CaminhoArquivo = ConfigurationManager.AppSettings["arquivo_nomes"];

        public static void Ler(string nome, int numero_arquivo)
        {
            #region Lendo arquivos
            string nome_arquivo = CaminhoArquivo + $"{nome}{numero_arquivo}.txt"; // Monta a string que gera o caminho do arquivo a ser lido
            if (File.Exists(nome_arquivo)) // verifica se arquivo existe
            {
                using (StreamReader arquivo = File.OpenText(nome_arquivo)) // Linha que abre o arquivo
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null) // Código que faz a leitura das linhas
                    {
                        Console.WriteLine(linha);
                    }
                }
                Ler(nome, numero_arquivo + 1); // Chama a função incrementando um ao número do arquivo
            }
            else
            {
                Console.WriteLine("Não existem mais arquivos para Ler!");
            }
            #endregion
        }
    }
}
