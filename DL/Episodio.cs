using System;
using System.Collections.Generic;

namespace DL;

public partial class Episodio
{
    public int IdEpisodio { get; set; }

    public string NumeroEpisodio { get; set; } = null!;

    public virtual ICollection<Podcast> Podcasts { get; set; } = new List<Podcast>();
}
