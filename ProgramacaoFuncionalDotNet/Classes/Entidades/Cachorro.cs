using Classes.Entidades.Abstracao;

namespace Classes.Entidades
{
    class Cachorro : AnimalAbstract
    {
        public override string Comunicar()
        {
            return "Latindo";
        }

        public override string Defender()
        {
            return "Morder";
        }
    }
}
