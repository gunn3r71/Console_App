using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Classes.Entidades
{
    class Usuario : Base
    {
        public Usuario()
        {
        }

        /// <summary>
        /// Construtor gerado aproveitando atributos da classe pai
        /// </summary>
        /// <param name="nome">Nome de usuário</param>
        /// <param name="telefone">Telefone de usuário</param>
        /// <param name="email">Email de usuário</param>
        public Usuario(string nome, string telefone, string email) : base(nome, telefone, email)
        {
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n"
                  + $"Telefone: {this.Telefone}\n"
                  + $"Email: {this.Email}\n";
        }
    }
}
