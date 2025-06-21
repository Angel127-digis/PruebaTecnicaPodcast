using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Podcast
    {
        public int IdPodcast { get; set; }
        public string? Nombre { get; set; }
        public Episodio? Episodio { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaDePublicacion { get; set; }
        public string? FechaDeCaducidad { get; set; }
        public string? AudioURL { get; set; }
        public Categoria? Categoria { get; set; }
        public byte[]? Imagen { get; set; }
        public int Duracion { get; set; }
        public Idioma? Idioma { get; set; }
        public List<object>? Podcasts { get; set; }
    }
}
