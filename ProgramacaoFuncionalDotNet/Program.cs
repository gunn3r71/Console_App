using Tela;
using Classes;
using System;

namespace ProgramacaoFuncionalDotNet
{
    class Program
    {
  
        static void Main(string[] args)
        {
            //Menu.Criar();

            var c = new Cliente();
            c.AdicionarCliente();

            var clientes = Cliente.LerClientes();

            foreach(var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }
    }
}
