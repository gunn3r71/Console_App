using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;


namespace Classes
{
    public class Cliente
    {
        public string Nome;
        public string Telefone;
        public string Email;
        private static string _db = ConfigurationManager.AppSettings["db"];

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(_db))
            {
                using (StreamReader arquivo = File.OpenText(_db)) // Linha que abre o arquivo
                {
                    string linha;
                    int i = 0;

                    while ((linha = arquivo.ReadLine()) != null) // Código que faz a leitura das linhas
                    {
                        i++;
                        if (i == 1) // código que ignora linha de cabeçalho
                        {
                            continue;
                        }
                        string[] dados = linha.Split(";");
                        clientes.Add(new Cliente { Nome = dados[0], Telefone = dados[1], Email = dados[2] });
                    }
                }
            }
            return clientes;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n"
                  +$"Telefone: {Telefone}\n"
                  +$"Email: {Email}\n";
        }
    }
}
