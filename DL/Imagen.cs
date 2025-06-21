using System;
using System.Collections.Generic;

namespace DL;

public partial class Imagen
{
    public int IdImagen { get; set; }

    public byte[]? Imagen1 { get; set; }

    public virtual ICollection<Podcast> Podcasts { get; set; } = new List<Podcast>();
}
