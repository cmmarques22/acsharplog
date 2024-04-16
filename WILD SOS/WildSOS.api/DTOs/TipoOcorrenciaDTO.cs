using WildSOS.api.Models;

namespace WildSOS.api.DTOs
{
    public class TipoOcorrenciaDto
    {

        public int IdTipoOcorrencia { get; set; }

        public string Descricao { get; set; } = null!;

        public TipoOcorrenciaDto ModelToDto(TipoOcorrencia model)
        {
            this.IdTipoOcorrencia = model.IdTipoOcorrencia;
            this.Descricao = model.Descricao;
            
            return this;
        }

        public TipoOcorrencia DtoToModel()
        {
            TipoOcorrencia tipoOcorrencia = new TipoOcorrencia()
            {
                IdTipoOcorrencia = this.IdTipoOcorrencia,
                Descricao = this.Descricao,
            };
            return tipoOcorrencia;
        }
    }
}

