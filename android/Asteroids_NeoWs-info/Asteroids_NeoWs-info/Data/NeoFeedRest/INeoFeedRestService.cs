using Asteroids_NeoWs_info.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.NeoFeedRest
{
    public interface INeoFeedRestService
    {
        Task<List<NeoFeedData>> RefreshDataAsync();
    }
}
