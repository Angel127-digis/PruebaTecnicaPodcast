using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class PodcastSP // DTO
    {
        //public int IdPodcast { get; set; }
        //public string? Nombre { get; set; }
        //public Episodio? Episodio { get; set; }
        //public string? Descripcion { get; set; }
        //public string? FechaDePublicacion { get; set; }
        //public string? FechaDeCaducidad { get; set; }
        //public string? AudioURL { get; set; }
        //public Categorium? Categoria { get; set; }
        //public byte[]? Imagen { get; set; }
        //public int Duracion { get; set; }
        //public Idioma? Idioma { get; set; }

        public int IdPodcast { get; set; }
        public string? Nombre { get; set; }
        public string NumeroEpisodio { get; set; } // Cambiado de Episodio?
        public string? Descripcion { get; set; }
        public DateTime? FechaDePublicacion { get; set; }
        public DateTime? FechaDeCaducidad { get; set; }
        public string? AudioURL { get; set; }
        public int IdCategoria { get; set; } // Añadido
        public string? Categoria { get; set; } // Nombre de categoría
        public byte[]? Imagen { get; set; }
        public int Duracion { get; set; }
        public string? Idioma { get; set; } // Nombre del idioma
    }
}
