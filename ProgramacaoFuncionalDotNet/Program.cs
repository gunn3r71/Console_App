using System;
using System.IO;
using System.Globalization;

namespace ProgramacaoFuncionalDotNet
{
    class Program
    {
        #region Definindo constantes de opções
        public const int SAIR = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int LIMPAR_TELA = 4;
        #endregion

        private static void ExibeMenu()
        {
            #region Exibe o Menu
            while (true)
            {
                string menu = "Olá Usuário, seja bem vindo ao nosso programa!!!\n\n"
                    + "Agora digite uma das opções abaixo: \n\n"
                    + $"Para Ler Arquivos, Digite {LER_ARQUIVOS};\n"
                    + $"Para Calcular uma tabuada, Digite {TABUADA};\n"
                    + $"Para Efetuar um cálcuo de média, Digite {CALCULO_MEDIA};\n"
                    + $"Para Limpar a tela, Digite {LIMPAR_TELA};\n\n";

                Console.WriteLine($"{menu}Digite {SAIR} para sair do programa!");
                Console.Write("> ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case SAIR:
                        Console.WriteLine("\n==============================================");
                        Console.WriteLine("Obrigado por utilizar nosso programa!!!");
                        Console.WriteLine("==============================================\n");
                        Environment.Exit(0);
                        break;
                    case LER_ARQUIVOS:
                        Console.WriteLine("\n================Ler Arquivos================\n");
                        Console.Write("Digite o nome e o número do arquivo separados por virgula ( Ex: Arq,1): ");
                        string[] arquivo = Console.ReadLine().Split(",");
                        string nome_arquivo = arquivo[0];
                        int numero_arquivo = int.Parse(arquivo[1]);
                        LerArquivos(nome_arquivo, numero_arquivo);
                        Console.WriteLine("\n============================================\n");
                        break;
                    case TABUADA:
                        Console.WriteLine("\n================Tabuada================\n");
                        Console.Write("Digite a tabuada desejada: ");
                        int numero_tabuada = int.Parse(Console.ReadLine());
                        ExibeTabuada(numero_tabuada);
                        Console.WriteLine("\n=======================================\n");
                        break;
                    case CALCULO_MEDIA:
                        Console.WriteLine("\n================Calcular Média================\n");
                        Console.Write("Digite 3 notas separados por virgula (9.5,10.0,8.5): ");
                        string[] notas = Console.ReadLine().Split(",");
                        CalcularMedia(double.Parse(notas[0], CultureInfo.InvariantCulture), double.Parse(notas[1], CultureInfo.InvariantCulture), double.Parse(notas[2], CultureInfo.InvariantCulture));
                        Console.WriteLine("\n==============================================\n");
                        break;
                    case LIMPAR_TELA:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\n==============================================");
                        Console.WriteLine("Atenção, a opção digitada é inválida");
                        Console.WriteLine("==============================================\n");
                        break;
                }
            }
            #endregion
        }

        public static void ExibeTabuada(int n)
        {
            #region Exibindo Tabuada
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }
            #endregion
        }

        public static void LerArquivos(string nome, int numero_arquivo)
        {
            #region Lendo arquivos
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
                LerArquivos(nome, numero_arquivo + 1); // Chama a função incrementando um ao número do arquivo
            }
            else
            {
                Console.WriteLine("Não existem mais arquivos para Ler!");
            }
            #endregion
        }

        public static void CalcularMedia(double nota1, double nota2, double nota3)
        {
            #region Calcula e exibe média
            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"Media calculada: {media.ToString("F2",CultureInfo.InvariantCulture)}");
            #endregion
        }

        static void Main(string[] args)
        {
            ExibeMenu();
        }
    }
}
