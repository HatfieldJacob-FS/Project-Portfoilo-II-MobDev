using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace ACC.Models
{
    class APIManager
    {
        //this is how we structure the api request
        WebClient apiConnection = new WebClient();
        string apiURL = $" https://api.edamam.com/search?app_id=411ecbf4&app_key=4a7a8ca28b50aef44f43aba41906582b&q=";
        string searchQuery { get; set; }
        string apiEndpoint
        {
            get
            {
                return apiURL + searchQuery;
            }
        }
        public APIManager(string recipes)
        {
            searchQuery = recipes;
        }


        public void GetRecipes()
        {
            string fullApi = apiConnection.DownloadString(apiEndpoint);
            JObject jsonData = JObject.Parse(fullApi);
            Debug.WriteLine(jsonData.ToString());
        }
    }
}
