using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;

namespace Classes.Entidades
{
    public class Cliente : Base
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

        /// <summary>
        /// Método criado para testar o recurso de base
        /// </summary>
        public virtual void DizerOla()
        {
            Console.WriteLine($"Olá,{Nome}");
        }

        /// <summary>
        /// Exemplo de método protegido, atua como um privado,
        /// porém, posso utilizar nas classes filhas.
        /// </summary>
        /// <returns>Retorna soma de 1+2</returns>
        protected int RetornarSoma() 
        {
            return 1 + 2;
        }

        internal string RetornaNome()
        {
            return $"Olá, {Nome}! posso ser utilizado em qualquer lugar, desde que esteja dentro do escopo deste projeto";
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n"
                  + $"Telefone: {this.Telefone}\n"
                  + $"Email: {this.Email}\n";
        }
    }
}
