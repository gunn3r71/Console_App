using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Entidades.Abstracao
{
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
