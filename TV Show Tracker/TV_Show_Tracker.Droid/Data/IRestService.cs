using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using TV_Show_Tracker.Droid.Model;

namespace TV_Show_Tracker.Droid.Data
{
    public interface IRestService
    {
        Task<List<JSONResponse>> RefreshDataAsync();
    }
}