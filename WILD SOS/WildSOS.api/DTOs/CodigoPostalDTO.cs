using WildSOS.api.Models;

namespace WildSOS.api.DTOs
{
    public class CodigoPostalDto
    {

        //propriedades
        public int IdCodigoPostal { get; set; }

        public string CodigoPostal1 { get; set; } = null!;

        public string Localidade { get; set; } = null!;

        public string Distrito { get; set; } = null!;

        public string Concelho { get; set; } = null!;

        public CodigoPostalDto ModelToDto(CodigoPostal model)
        {
            this.IdCodigoPostal = model.IdCodigoPostal;
            this.CodigoPostal1 = model.CodigoPostal1;
            this.Localidade = model.Localidade;
            this.Distrito = model.Distrito;
            this.Concelho = model.Concelho;

            return this;
        }

        public CodigoPostal DtoToModel()
        {
            CodigoPostal codigoPostal = new CodigoPostal()
            {
                IdCodigoPostal = this.IdCodigoPostal,
                CodigoPostal1 = this.CodigoPostal1,
                Localidade = this.Localidade,
                Distrito = this.Distrito,
                Concelho = this.Concelho,

            };
            return codigoPostal;
        }

    }
}