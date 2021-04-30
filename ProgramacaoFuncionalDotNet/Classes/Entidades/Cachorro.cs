using Classes.Entidades.Abstracao;

namespace Classes.Entidades
{
    class Cachorro : AnimalAbstract
    {
        public int idade; //propriedade simples
        private string nomeDono = "Lucas";

        public string Raca { get; set; } //propriedade complexa
        public string NomeDono //propriedade complexa somente com get   
        { 
            get 
            {
                return nomeDono;           
            }
        }

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
