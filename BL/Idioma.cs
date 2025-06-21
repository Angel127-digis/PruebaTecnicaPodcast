using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Idioma : IIdioma
    {
        private readonly PodcastContext _context;

        public Idioma(PodcastContext context)
        {
            _context = context;
        }

        public ML.Result IdiomaGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                var listaIdioma = (from idioma in _context.Idiomas
                                     select new
                                     {
                                         idioma.IdIdioma,
                                         idioma.Idioma1
                                     }).ToList();

                if (listaIdioma != null)
                {
                    result.Objects = new List<object>();
                    foreach (var registroIdioma in listaIdioma)
                    {
                        ML.Idioma idioma = new ML.Idioma();
                        idioma.IdIdioma = registroIdioma.IdIdioma;
                        idioma.NombreIdioma = registroIdioma.Idioma1;
                        result.Objects.Add(idioma);
                    }
                    result.Correcto = true;
                }
                else
                {
                    result.Correcto = false;
                    result.MensajeError = "No se encontraron registros de Idioma";
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
