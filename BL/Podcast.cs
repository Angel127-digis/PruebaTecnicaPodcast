using DL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BL
{
    public class Podcast : IPodcast
    {
        private readonly PodcastContext _context;

        public Podcast(PodcastContext context)
        {
            _context = context;
        }

        public ML.Result PodcastGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                var listaPodcast = _context.PodcastSP.FromSqlRaw($"PodcastGetALL").ToList();

                if (listaPodcast != null)
                {
                    result.Objects = new List<object>();
                    foreach (var registroPodcast in listaPodcast)
                    {
                        ML.Podcast podcast = new ML.Podcast();
                        podcast.Episodio = new ML.Episodio();
                        podcast.Categoria = new ML.Categoria();
                        podcast.Idioma = new ML.Idioma();

                        podcast.IdPodcast = registroPodcast.IdPodcast;
                        podcast.Nombre = registroPodcast.Nombre;
                        podcast.Episodio.NumeroEpisodio = registroPodcast.NumeroEpisodio;
                        podcast.Descripcion = registroPodcast.Descripcion;
                        podcast.FechaDePublicacion = string.Format("{0:dd/MM/yyyy}", registroPodcast.FechaDePublicacion);
                        podcast.FechaDeCaducidad = string.Format("{0:dd/MM/yyyy}", registroPodcast.FechaDeCaducidad);
                        podcast.AudioURL = registroPodcast.AudioURL;
                        podcast.Categoria.IdCategoria = registroPodcast.IdCategoria;
                        podcast.Categoria.NombreCategoria = registroPodcast.Categoria;
                        podcast.Imagen = registroPodcast.Imagen;
                        podcast.Duracion = registroPodcast.Duracion;
                        podcast.Idioma.NombreIdioma = registroPodcast.Idioma;
                        result.Objects.Add(podcast);
                    }
                    result.Correcto = true;
                }
                else
                {
                    result.Correcto = false;
                    result.MensajeError = "No se encontraron registros";
                }

            }
            catch (Exception ex)
            {
                result.Correcto = true;
                result.MensajeError = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public ML.Result PodcastGetById(int IdPodcast)
        {
            ML.Result result = new ML.Result();
            try
            {
                var listaPodcast = _context.PodcastSP.FromSqlRaw($"PodcastGetById {IdPodcast}").AsEnumerable().SingleOrDefault();

                if (listaPodcast != null)
                {

                    var registroPodcast = listaPodcast;

                    ML.Podcast podcast = new ML.Podcast();
                    podcast.Episodio = new ML.Episodio();
                    podcast.Categoria = new ML.Categoria();
                    podcast.Idioma = new ML.Idioma();

                    podcast.IdPodcast = registroPodcast.IdPodcast;
                    podcast.Nombre = registroPodcast.Nombre;
                    podcast.Episodio.NumeroEpisodio = registroPodcast.NumeroEpisodio;
                    podcast.Descripcion = registroPodcast.Descripcion;
                    podcast.FechaDePublicacion = string.Format("{0:dd/MM/yyyy}", registroPodcast.FechaDePublicacion);
                    podcast.FechaDeCaducidad = string.Format("{0:dd/MM/yyyy}", registroPodcast.FechaDeCaducidad);
                    podcast.AudioURL = registroPodcast.AudioURL;
                    podcast.Categoria.IdCategoria = registroPodcast.IdCategoria;
                    podcast.Categoria.NombreCategoria = registroPodcast.Categoria;
                    podcast.Imagen = registroPodcast.Imagen;
                    podcast.Duracion = registroPodcast.Duracion;
                    podcast.Idioma.NombreIdioma = registroPodcast.Idioma;
                    result.Object = podcast;

                    result.Correcto = true;
                }
                else
                {
                    result.Correcto = false;
                    result.MensajeError = "No se encontraron registros";
                }

            }
            catch (Exception ex)
            {
                result.Correcto = true;
                result.MensajeError = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public ML.Result PodcastAdd(ML.Podcast podcast)
        {
            ML.Result result = new ML.Result();
            try
            {
                //var listaPodcast = _context.Database.ExecuteSql($"PodcastAdd {podcast.Nombre}");

                DL.Podcast podcastBd = new DL.Podcast();
                podcast.Episodio = new ML.Episodio();
                podcast.Categoria = new ML.Categoria();
                podcast.Idioma = new ML.Idioma();

                podcastBd.Nombre = podcast.Nombre;
                podcastBd.IdEpisodio = podcast.Episodio.IdEpisodio;
                podcastBd.Descripcion = podcast.Descripcion;
                podcastBd.FechaDePublicacion = DateOnly.Parse(podcast.FechaDePublicacion);
                podcastBd.FechaDeCaducidad = DateOnly.Parse(podcast.FechaDeCaducidad);
                podcastBd.AudioUrl = podcast.AudioURL;
                podcastBd.IdCategoria = podcast.Categoria.IdCategoria;
                podcastBd.Imagen = podcast.Imagen;
                podcastBd.Duracion = podcast.Duracion;
                podcastBd.IdIdioma = podcast.Idioma.IdIdioma;

                _context.Podcasts.Add(podcastBd);
                int filasAfectadas = _context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    result.Correcto = true;
                }
                else
                {
                    result.Correcto = false;
                    result.MensajeError = "No se pudo agregar el registro";
                }

            }
            catch (Exception ex)
            {
                result.Correcto = true;
                result.MensajeError = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
    }
}
