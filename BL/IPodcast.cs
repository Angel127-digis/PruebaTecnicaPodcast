using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPodcast
    {
        ML.Result PodcastGetAll();
        ML.Result PodcastGetById(int IdPodcast);
        ML.Result PodcastAdd(ML.Podcast podcast);
    }
}
