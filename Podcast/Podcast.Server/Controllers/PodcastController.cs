using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Podcast.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodcastController : ControllerBase
    {
        private readonly IPodcast _context;
        private readonly IEpisodio _episodio;
        private readonly ICategoria _categoria;
        private readonly IIdioma _idioma;


        public PodcastController(IPodcast context, IEpisodio episodio, ICategoria categoria, IIdioma idioma)
        {
            _context = context;
            _episodio = episodio;
            _categoria = categoria;
            _idioma = idioma;
        }

        [HttpGet]
        [Route("getPodcasts")]
        public IActionResult GetAll()
        {
            var result = _context.PodcastGetAll();
            if (result.Correcto)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("getPodcastById/{IdPodcast}")]
        public IActionResult GetById(int IdPodcast)
        {
            var result = _context.PodcastGetById(IdPodcast);
            if (result.Correcto)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("addPodcast")]
        public IActionResult Add([FromBody] ML.Podcast podcast)
        {
            var result = _context.PodcastAdd(podcast);
            if (result.Correcto)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("getEpisodios")]
        public IActionResult GetEpisodios()
        {
            var result = _episodio.EpisodioGetAll();
            if (result.Correcto)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("getCategorias")]
        public IActionResult GetCategorias()
        {
            var result = _categoria.CategoriaGetAll();
            if (result.Correcto)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("getIdiomas")]
        public IActionResult GetIdiomas()
        {
            var result = _idioma.IdiomaGetAll();
            if (result.Correcto)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
