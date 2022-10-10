using Asteroids_NeoWs_info.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.BrowseRest
{
    public class BrowseItemManager
    {
        IBrowseRestService restService;

        public BrowseItemManager(IBrowseRestService service)
        {
            restService = service;
        }

        public Task<List<BrowseData>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }

    }
}
