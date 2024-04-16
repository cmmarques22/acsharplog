using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class LinhaSos
{
    public int IdLinhaSos { get; set; }

    public string Nome { get; set; } = null!;

    public string Morada { get; set; } = null!;

    public int IdCodigoPostal { get; set; }

    public string Email { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public virtual CodigoPostal IdCodigoPostalNavigation { get; set; } = null!;

    public virtual ICollection<LinhaSostipoOcorrencia> LinhaSostipoOcorrencia { get; set; } = new List<LinhaSostipoOcorrencia>();
}
