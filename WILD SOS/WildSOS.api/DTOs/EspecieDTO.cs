using WildSOS.api.Models;

namespace WildSOS.api.DTOs
{
    public class EspecieDto
    {

        //propriedades
        public int IdEspecie { get; set; }
        public string Classe { get; set; } = null!;

        public string Especie1 { get; set; } = null!;

        public EspecieDto ModelToDto(Especie model)
        {
            this.IdEspecie = model.IdEspecie;
            this.Classe = model.Classe;
            this.Especie1 = model.Especie1;
            return this;
        }

        public Especie DtoToModel()
        {
            Especie especie = new Especie()
            {
                IdEspecie = this.IdEspecie,
                Classe = this.Classe,
                Especie1 = this.Especie1,
            };
            return especie;
        }



    }
}



