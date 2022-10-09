using Asteroids_NeoWs_info.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asteroids_NeoWs_info.Data
{
	public class NeoFeedItemManager
	{
		IRestService restService;

		public NeoFeedItemManager (IRestService service)
		{
			restService = service;
		}

		public Task<List<NeoFeed>> GetTasksAsync ()
		{
			return restService.RefreshDataAsync ();	
		}

	}
}
