using System;
using System.Collections.Generic;

namespace Podcast.Server;

public partial class Podcast
{
    public int IdPodcast { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEpisodio { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly FechaDePublicacion { get; set; }

    public DateOnly FechaDeCaducidad { get; set; }

    public string AudioUrl { get; set; } = null!;

    public int IdCategoria { get; set; }

    public byte[]? Imagen { get; set; }

    public int Duracion { get; set; }

    public int IdIdioma { get; set; }

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;

    public virtual Episodio IdEpisodioNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
