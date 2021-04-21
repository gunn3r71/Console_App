using Calculo;
using Pastas;
using System;
using System.Globalization;

namespace Tela
{
    class Menu
    {
        #region Definindo constantes de opções
        private const int SAIR = 0;
        private const int LER_ARQUIVOS = 1;
        private const int TABUADA = 2;
        private const int CALCULO_MEDIA = 3;
        private const int LIMPAR_TELA = 4;
        #endregion

        public static void Criar()
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
                        Arquivo.Ler(nome_arquivo, numero_arquivo);
                        Console.WriteLine("\n============================================\n");
                        break;
                    case TABUADA:
                        Console.WriteLine("\n================Tabuada================\n");
                        Console.Write("Digite a tabuada desejada: ");
                        int numero_tabuada = int.Parse(Console.ReadLine());
                        Tabuada.Calcular(numero_tabuada);
                        Console.WriteLine("\n=======================================\n");
                        break;
                    case CALCULO_MEDIA:
                        Console.WriteLine("\n================Calcular Média================\n");
                        Console.Write("Digite 3 notas separados por virgula (9.5,10.0,8.5): ");
                        string[] notas = Console.ReadLine().Split(",");
                        Media.Nota(double.Parse(notas[0], CultureInfo.InvariantCulture), double.Parse(notas[1], CultureInfo.InvariantCulture), double.Parse(notas[2], CultureInfo.InvariantCulture));
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
    }
}
