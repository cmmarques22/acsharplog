using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class TipologiaUser
{
    public int IdTipoUser { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
