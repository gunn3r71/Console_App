using Classes.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Classes.Entidades
{
    public abstract class Base : IPessoa
    {

        public Base()
        {
           this._db = ConfigurationManager.AppSettings["db"] + this.GetType().Name + "_db.csv";
        }

        public Base(string nome, string telefone, string email) : this()
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        /// <summary>
        /// Gerando atributos genéricos 
        /// </summary>
        public string Nome;
        public string Telefone;
        public string Email;
        private string _db;


        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public virtual void Adicionar()
        {
            if (File.Exists(_db))
            {
                using (var writer = new StreamWriter(_db, true))
                {
                    writer.WriteLine(this.RetornaFormatado());
                }
                Console.WriteLine($"\n\n{this.GetType().Name} Adicionado com sucesso!!!");
            }
            else
            {
                Console.WriteLine("\n\nDiretório inexistene, verifique o caminho do arquivo e tente novamente!");
            }
        }

        public List<IPessoa> Ler()
        {
            var pessoas = new List<IPessoa>();
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
                        var pessoa = (IPessoa)Activator.CreateInstance(this.GetType()); // Activator cria um objeto em memória de forma genérica
                        pessoa.SetNome(dados[0]);
                        pessoa.SetTelefone(dados[1]);
                        pessoa.setEmail(dados[2]);
                        pessoas.Add(pessoa);
                    }
                }
            }
            return pessoas;
        }

        //Assim que chamado método captura atributos da instância atual e converte para inserção
        public string RetornaFormatado()
        {
            return $"{this.Nome};{this.Telefone};{this.Email};";
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n"
                  + $"Telefone: {this.Telefone}\n"
                  + $"Email: {this.Email}\n";
        }
    }
}
