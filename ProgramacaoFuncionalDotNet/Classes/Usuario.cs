using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Classes
{
    class Usuario : Cliente
    {
        private static string _db = ConfigurationManager.AppSettings["usuarios_db"];

        public Usuario(string nome, string telefone, string email) : base(nome, telefone, email)
        {
        }

        /// <summary>
        /// Método auxiliar para converter o usuário numa string compátivel com o banco
        /// </summary>
        /// <param name="usuario">Instância de Cliente requerida</param>
        /// <returns></returns>
        private string RetornaFormatado(Usuario usuario)
        {
            return $"{usuario.Nome};{usuario.Telefone};{usuario.Email};";
        }

        /// <summary>
        /// Método utilizado para adicionar Usuários a base de dados
        /// </summary>
        public override void Adicionar() //override sobreescreve o método da classe pai
        {
            if (File.Exists(_db))
            {
                using (var writer = new StreamWriter(_db, true))
                {
                    writer.WriteLine(RetornaFormatado(this));
                }
                Console.WriteLine("\n\nUsuário Adicionado com sucesso!!!");
            }
            else
            {
                Console.WriteLine("\n\nDiretório inexistene, verifique o caminho do arquivo e tente novamente!");
            }
        }

        /// <summary>
        /// Método utilizado para ler banco de dados de usuarios
        /// </summary>
        /// <returns>Retorna uma lista de usários</returns>
        public static new List<Usuario> Ler() //new força a sobrescrita do método da classe pai
        {
            var usuarios = new List<Usuario>();
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
                        usuarios.Add(new Usuario(dados[0],dados[1],dados[2]));
                    }
                }
            }
            return usuarios;
        }
    }
}
