using Classes;
using System;

namespace Tela
{
    class TelaUsuario
    {
        private const int SAIR = 0;
        private const int CADASTRAR_USUARIO= 1;
        private const int LISTAR_USUARIOS = 2;

        public static void Mostrar()
        {
            bool continuar = true;
            while (continuar)
            {
                string menu = "\n\nVocê está no menu Usuários\n\n"
                        + $"Para Cadastrar cliente, Digite {CADASTRAR_USUARIO};\n"
                        + $"Para Listar os clientes, Digite {LISTAR_USUARIOS};\n";

                Console.WriteLine($"{menu}Digite {SAIR} para sair de Usuários!");
                Console.Write("> ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case SAIR:
                        continuar = false;
                        Console.WriteLine("\n==============================================");
                        Console.WriteLine("Saindo....");
                        Console.WriteLine("==============================================\n");
                        break;
                    case CADASTRAR_USUARIO:
                        Console.WriteLine("\n================Cadastrar Usuário================\n");
                        Console.Write("Para começar, insira o nome do usuário: ");
                        string nome = Console.ReadLine();
                        Console.Write("Agora insira o telefone do usuário(Apenas números): ");
                        string telefone = Console.ReadLine();
                        Console.Write("Agora insira o email do usuário: ");
                        string email = Console.ReadLine();

                        var usuario = new Usuario(nome, telefone.ToString(), email);
                        usuario.Adicionar();
                        Console.WriteLine("\n=================================================\n");
                        break;
                    case LISTAR_USUARIOS:
                        Console.WriteLine("\n================Listar Usuários================\n");
                        Console.WriteLine("Clientes:");
                        var usuarios = Usuario.Ler();
                        foreach (var u in usuarios)
                        {
                            Console.WriteLine(u);
                        }
                        Console.WriteLine("\n=================================================\n");
                        break;
                    default:
                        Console.WriteLine("\n==============================================");
                        Console.WriteLine("Atenção, a opção digitada é inválida");
                        Console.WriteLine("==============================================\n");
                        break;
                }
            }
        }
    }
}
