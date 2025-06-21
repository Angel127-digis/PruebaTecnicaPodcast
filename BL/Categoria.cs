using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Categoria : ICategoria
    {
        private readonly PodcastContext _context;

        public Categoria(PodcastContext context)
        {
            _context = context;
        }

        public ML.Result CategoriaGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                var listaCategorias = (from categoria in _context.Categoria
                                       select new
                                       {
                                           categoria.IdCategoria,
                                           categoria.Categoria
                                       }).ToList();

                if (listaCategorias != null)
                {
                    result.Objects = new List<object>();
                    foreach (var registroCategoria in listaCategorias)
                    {
                        ML.Categoria categoria = new ML.Categoria();
                        categoria.IdCategoria = registroCategoria.IdCategoria;
                        categoria.NombreCategoria = registroCategoria.Categoria;
                        result.Objects.Add(categoria);
                    }
                    result.Correcto = true;
                }
                else
                {
                    result.Correcto= false;
                    result.MensajeError = "No se encontraron registros de Categoria";
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
