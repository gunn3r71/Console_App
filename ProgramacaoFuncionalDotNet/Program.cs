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
            var clientes = Cliente.LerClientes();

            foreach(var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }
    }
}
