using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TV_Show_Tracker.Droid.Data
{
    public class TVMazeRESTService : IRestService
    {
        HttpClient client;

        public List<string> Items { get; private set; }

        public TVMazeRESTService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }
        public async Task<List<string>> RefreshDataAsync()
        {
            Items = new List<string>();

            //var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            var uri = new Uri(string.Format("http://api.tvmaze.com/search/shows?q=girls", string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<string>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("@             Error {0}", ex.Message);
            }
            return Items;
        }
    }
}