using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TV_Show_Tracker.Droid.Data
{
    public interface IRestService
    {
        Task<List<string>> RefreshDataAsync();
    }
}