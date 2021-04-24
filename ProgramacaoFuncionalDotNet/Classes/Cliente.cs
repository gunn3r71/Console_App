﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;


namespace Classes
{
    public class Cliente
    {
        /// <summary>
        /// Construtor Padrão caso não queira preencher logo de inicio
        /// </summary>
        public Cliente()
        {
        }

        /// <summary>
        /// Construtor com nome e telefone obrigatórios
        /// </summary>
        /// <param name="nome">Nome do cliente</param>
        /// <param name="telefone">Telefone do cliente</param>
        public Cliente(string nome,string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }

        /// <summary>
        /// Construtor com nome, telefone e email obrigatórios
        /// </summary>
        /// <param name="nome">Nome do cliente</param>
        /// <param name="telefone">Telefone do cliente</param>
        /// <param name="email">Email do cliente</param>
        public Cliente(string nome, string telefone, string email) : this(nome,telefone)
        {   
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }


        public string Nome;
        public string Telefone;
        public string Email;
        private static string _db = ConfigurationManager.AppSettings["db"];

        /// <summary>
        /// Método auxiliar para converter o cliente numa string compátivel com o banco
        /// </summary>
        /// <param name="cliente">Instância de Cliente requerida</param>
        /// <returns></returns>
        public string RetornaClienteFormatado(Cliente cliente)
        {
            return $"{cliente.Nome};{cliente.Telefone};{cliente.Email};";
        }

        /// <summary>
        /// Método que adiciona cliente ao banco de dados
        /// </summary>
        public void AdicionarCliente(Cliente cliente)
        {
            if (File.Exists(_db))
            {
                using (var writer = new StreamWriter(_db, true))
                {
                    writer.WriteLine(RetornaClienteFormatado(cliente));
                }
            }
        }

        /// <summary>
        /// Método que retorna lista de todos os clientes presentes no banco
        /// </summary>
        /// <returns>Lista de clientes</returns>
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
                        string[] dados = linha.Split(';');
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
