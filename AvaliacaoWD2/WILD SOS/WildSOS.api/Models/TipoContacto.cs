using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class TipoContacto
{
    public int IdTipoContacto { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();
}
