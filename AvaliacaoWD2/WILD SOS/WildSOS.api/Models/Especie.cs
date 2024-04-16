using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class Especie
{
    public int IdEspecie { get; set; }

    public string Classe { get; set; } = null!;

    public string Especie1 { get; set; } = null!;

    public virtual ICollection<Ocorrencia> Ocorrencia { get; set; } = new List<Ocorrencia>();
}
