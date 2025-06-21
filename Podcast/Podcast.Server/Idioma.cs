using System;
using System.Collections.Generic;

namespace Podcast.Server;

public partial class Idioma
{
    public int IdIdioma { get; set; }

    public string Idioma1 { get; set; } = null!;

    public virtual ICollection<Podcast> Podcasts { get; set; } = new List<Podcast>();
}
