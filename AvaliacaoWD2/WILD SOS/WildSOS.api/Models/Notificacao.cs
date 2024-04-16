using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class Notificacao
{
    public int IdNotificacao { get; set; }

    public int IdOcorrencia { get; set; }

    public int IdUser { get; set; }

    public string? Texto { get; set; }

    public virtual Ocorrencia IdOcorrenciaNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
