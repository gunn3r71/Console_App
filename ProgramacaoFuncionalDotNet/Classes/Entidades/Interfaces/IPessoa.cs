using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Entidades.Interfaces
{
    public interface IPessoa
    {
        //interface é um contrato que obriga que todos que a implementem, implementem todos os métodos e atributos definidos
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void setEmail(string email);
        void Adicionar();
        List<IPessoa> Ler();
        string RetornaFormatado();
    }
}
