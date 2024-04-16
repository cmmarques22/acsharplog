using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class LinhaSostipoOcorrencia
{
    public int IdLinhaSos { get; set; }

    public int IdTipoOcorrencia { get; set; }

    public int Ordem { get; set; }

    public virtual LinhaSos IdLinhaSosNavigation { get; set; } = null!;

    public virtual TipoOcorrencia IdTipoOcorrenciaNavigation { get; set; } = null!;
}
