using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class Contacto
{
    public int IdContacto { get; set; }

    public int IdUser { get; set; }

    public int IdTipoContacto { get; set; }

    public string Valor { get; set; } = null!;

    public virtual TipoContacto IdTipoContactoNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
