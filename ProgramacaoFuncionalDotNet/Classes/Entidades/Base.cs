using Classes.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Entidades
{
    public class Base : IPessoa
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

        public void Adicionar()
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

        public List<Base> Ler()
        {
            var pessoas = new List<Base>();
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
                        pessoas.Add(new Base { Nome = dados[0], Telefone = dados[1], Email = dados[2] });
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
