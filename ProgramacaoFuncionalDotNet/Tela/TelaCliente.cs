using Classes;
using Classes.Entidades;
using System;

namespace Tela
{
    class TelaCliente
    {
        private const int SAIR = 0;
        private const int CADASTRAR_CLIENTE = 1;
        private const int LISTAR_CLIENTES = 2;

        public static void Mostrar()
        {
            bool continuar = true;
            while (continuar)
            {
                string menu = "\n\nVocê está no menu Clientes\n\n"
                        + $"Para Cadastrar cliente, Digite {CADASTRAR_CLIENTE};\n"
                        + $"Para Listar os clientes, Digite {LISTAR_CLIENTES};\n";

                Console.WriteLine($"{menu}Digite {SAIR} para sair de Clientes!");
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
                    case CADASTRAR_CLIENTE:
                        Console.WriteLine("\n================Cadastrar Cliente================\n");
                        Console.Write("Para começar, insira o nome do cliente: ");
                        string nome = Console.ReadLine();
                        Console.Write("Agora insira o telefone do cliente(Apenas números): ");
                        string telefone = Console.ReadLine();
                        Console.Write("Agora insira o email do cliente: ");
                        string email = Console.ReadLine();

                        var cliente = new Cliente(nome, telefone.ToString(), email);
                        cliente.Adicionar();
                        Console.WriteLine("\n=================================================\n");
                        break;
                    case LISTAR_CLIENTES:
                        Console.WriteLine("\n================Listar Clientes================\n");
                        Console.WriteLine("Clientes:");
                        var clientes = new Cliente();
                        foreach (var c in clientes.Ler())
                        {
                            Console.WriteLine(c);
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
