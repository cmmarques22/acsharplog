using System;
using System.Collections.Generic;

namespace WildSOS.api.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string Nome { get; set; } = null!;

    public string Morada { get; set; } = null!;

    public int IdCodigoPostal { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdTipoUser { get; set; }

    public DateTime DataAtualização { get; set; }

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();

    public virtual CodigoPostal IdCodigoPostalNavigation { get; set; } = null!;

    public virtual TipologiaUser IdTipoUserNavigation { get; set; } = null!;

    public virtual ICollection<Notificacao> Notificacaos { get; set; } = new List<Notificacao>();

    public virtual ICollection<Ocorrencia> Ocorrencia { get; set; } = new List<Ocorrencia>();
}
