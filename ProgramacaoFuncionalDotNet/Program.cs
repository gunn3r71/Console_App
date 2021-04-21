using System;

namespace ProgramacaoFuncionalDotNet
{
    class Program
    {
        public const int SAIR = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

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
                        break;
                    case 1:
                        break;
                    case 2:
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
