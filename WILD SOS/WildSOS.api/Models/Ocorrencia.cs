using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class Ocorrencia
{
    public int IdOcorrencia { get; set; }

    public DateTime DataHora { get; set; }

    public string Descricao { get; set; } = null!;

    public string Localizacao { get; set; } = null!;

    public string? Estado { get; set; }

    public int? IdTipoOcorrencia { get; set; }

    public int IdUser { get; set; }

    public int? IdEspecie { get; set; }

    public virtual Especie? IdEspecieNavigation { get; set; }

    public virtual TipoOcorrencia IdTipoOcorrenciaNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<Notificacao> Notificacaos { get; set; } = new List<Notificacao>();
}
