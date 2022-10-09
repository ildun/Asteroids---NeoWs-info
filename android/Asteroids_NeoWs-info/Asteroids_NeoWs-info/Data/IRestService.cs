using Asteroids_NeoWs_info.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asteroids_NeoWs_info.Data
{
	public interface IRestService
	{
		Task<List<NeoFeed>> RefreshDataAsync ();
    }
}
