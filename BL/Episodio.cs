using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Episodio : IEpisodio
    {
        private readonly PodcastContext _context;

        public Episodio(PodcastContext context)
        {
            _context = context;
        }

        public ML.Result EpisodioGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                var listaEpisodio = (from episodio in _context.Episodios
                                       select new
                                       {
                                           episodio.IdEpisodio,
                                           episodio.NumeroEpisodio
                                       }).ToList();

                if (listaEpisodio != null)
                {
                    result.Objects = new List<object>();
                    foreach (var registroEpisodio in listaEpisodio)
                    {
                        ML.Episodio episodio = new ML.Episodio();
                        episodio.IdEpisodio = registroEpisodio.IdEpisodio;
                        episodio.NumeroEpisodio = registroEpisodio.NumeroEpisodio;
                        result.Objects.Add(episodio);
                    }
                    result.Correcto = true;
                }
                else
                {
                    result.Correcto = false;
                    result.MensajeError = "No se encontraron registros de Episodio";
                }
            }
            catch (Exception ex)
            {
                result.Correcto = false;
                result.MensajeError = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
