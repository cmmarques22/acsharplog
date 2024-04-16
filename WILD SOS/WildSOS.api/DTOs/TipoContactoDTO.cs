using WildSOS.api.Models;

namespace WildSOS.api.DTOs
{
    public class TipoContactoDto
    {

        //propriedades
        public int IdTipoContacto { get; set; }

        public string Descricao { get; set; } = null!;

        public TipoContactoDto ModelToDto(TipoContacto model)
        {
            this.IdTipoContacto = model.IdTipoContacto;
            this.Descricao = model.Descricao;
           
            return this;
        }

        public TipoContacto DtoToModel()
        {
            TipoContacto tipoContacto = new TipoContacto()
            {
                IdTipoContacto = this.IdTipoContacto,
                Descricao = this.Descricao,
            };
            return tipoContacto;
        }



    }
}