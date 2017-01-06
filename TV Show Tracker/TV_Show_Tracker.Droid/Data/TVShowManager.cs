using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TV_Show_Tracker.Droid.Model;

namespace TV_Show_Tracker.Droid.Data
{
    public class TVShowManager
    {
        IRestService restService;

        public TVShowManager(IRestService service)
        {
            restService = service;
        }
        public Task<List<JSONResponse>> GetShowsAsync()
        {
            return restService.RefreshDataAsync();
        }
    }
}