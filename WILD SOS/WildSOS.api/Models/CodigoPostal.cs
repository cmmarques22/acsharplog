using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class CodigoPostal
{
    public int IdCodigoPostal { get; set; }

    public string CodigoPostal1 { get; set; } = null!;

    public string Localidade { get; set; } = null!;

    public string Distrito { get; set; } = null!;

    public string Concelho { get; set; } = null!;

    public virtual ICollection<LinhaSos> LinhaSos { get; set; } = new List<LinhaSos>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
