using Asteroids_NeoWs_info.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.BrowseRest
{
    public interface IBrowseRestService
    {
        Task<List<BrowseData>> RefreshDataAsync();
    }
}
