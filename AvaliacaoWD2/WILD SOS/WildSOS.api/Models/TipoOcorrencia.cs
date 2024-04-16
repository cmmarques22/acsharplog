using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WildSOS.api.Models;

public partial class TipoOcorrencia
{
   
    public int IdTipoOcorrencia { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual ICollection<LinhaSostipoOcorrencia> LinhaSostipoOcorrencia { get; set; } = new List<LinhaSostipoOcorrencia>();

    public virtual ICollection<Ocorrencia> Ocorrencia { get; set; } = new List<Ocorrencia>();
}
