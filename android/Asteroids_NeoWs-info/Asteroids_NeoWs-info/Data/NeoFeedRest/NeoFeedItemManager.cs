using Asteroids_NeoWs_info.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.NeoFeedRest
{
    public class NeoFeedItemManager
    {
        INeoFeedRestService restService;

        public NeoFeedItemManager(INeoFeedRestService service)
        {
            restService = service;
        }

        public Task<List<NeoFeedData>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }

    }
}
