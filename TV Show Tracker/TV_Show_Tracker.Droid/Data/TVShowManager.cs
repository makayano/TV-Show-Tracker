using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TV_Show_Tracker.Droid.Data
{
    public class TVShowManager
    {
        IRestService restService;

        public TVShowManager(IRestService service)
        {
            restService = service;
        }
        public Task<List<string>> GetShowsAsync()
        {
            return restService.RefreshDataAsync();
        }
    }
}