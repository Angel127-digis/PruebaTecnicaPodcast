using System;
using System.Collections.Generic;

namespace DL;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string Categoria { get; set; } = null!;

    public virtual ICollection<Podcast> Podcasts { get; set; } = new List<Podcast>();
}
