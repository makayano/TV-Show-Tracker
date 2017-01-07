using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TV_Show_Tracker.Droid.Model;

namespace TV_Show_Tracker.Droid.Data
{
    public class TVMazeRESTService : IRestService
    {
        HttpClient client;

        public List<RootObject> showList { get; private set; }

        public TVMazeRESTService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }
        public async Task<List<RootObject>> RefreshDataAsync()
        {
            //var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            var uri = new Uri(string.Format("http://api.tvmaze.com/search/shows?q=girls", string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    showList = JsonConvert.DeserializeObject<List<RootObject>>(content);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("@             Error {0}", ex.Message);
            }
            return showList;
        }
    }
}