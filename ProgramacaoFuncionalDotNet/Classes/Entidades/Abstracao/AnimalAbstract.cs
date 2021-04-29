using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Entidades.Abstracao
{
    /// <summary>
    /// Essa classe abstrata funciona como se fosse uma interface
    /// porém com ela conseguimos implementar métodos e tornar
    /// outros abstratos fazendo com que a classe que herde dessa
    /// receba os métodos já implementados e seja obrigado
    /// a implementar os métodos abstratos
    /// </summary>
    public abstract class  AnimalAbstract
    {
        public string Nome;
        public string Tipo;
        public string habitat;

        public abstract string Defender();

        public abstract string Comunicar();

        public string Dormir()
        {
            return "Dormindo";
        }
    }
}
