﻿using System;
using System.IO;

namespace ProgramacaoFuncionalDotNet
{
    class Program
    {
        public const int SAIR = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void ExibeTabuada(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }
        }

        public static void LerArquivo(string nome, int numero_arquivo)
        {
            string nome_arquivo = $@"C:\ArquivosDotNetRead\{nome}{numero_arquivo}.txt"; // Monta a string que gera o caminho do arquivo a ser lido
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
                LerArquivo(nome, numero_arquivo + 1); // Chama a função incrementando um ao número do arquivo
            }
            else
            {
                Console.WriteLine("Não existem mais arquivos para Ler!");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string menu = "Olá Usuário, seja bem vindo ao nosso programa!!!\n\n"
                    + "Agora digite uma das opções abaixo: \n\n"
                    + $"Para Ler Arquivos, Digite {LER_ARQUIVOS};\n"
                    +$"Para Calcular uma tabuada, Digite {TABUADA};\n"
                    +$"Para Efetuar um cálcuo de média, Digite {CALCULO_MEDIA};\n\n";

                Console.WriteLine($"{menu}Digite {SAIR} para sair do programa!");
                Console.Write("> ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar nosso programa!!!");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("\n================Ler Arquivos================\n");
                        Console.Write("Digite o nome e o número do arquivo separados por virgula ( Ex: Arq,1): ");
                        string[] arquivo = Console.ReadLine().Split(",");
                        string nome_arquivo = arquivo[0];
                        int numero_arquivo = int.Parse(arquivo[1]);
                        LerArquivo(nome_arquivo,numero_arquivo);
                        Console.WriteLine("\n============================================\n");
                        break;
                    case 2:
                        Console.WriteLine("\n================Tabuada================\n");
                        Console.Write("Digite a tabuada desejada: ");
                        int numero_tabuada = int.Parse(Console.ReadLine());
                        ExibeTabuada(numero_tabuada);
                        Console.WriteLine("\n=======================================\n");
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
