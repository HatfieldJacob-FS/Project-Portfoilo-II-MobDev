using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace API_Test_File.Models
{
   public class DataManager
    {
        //string apiID = "0ff705b0";
        //string apiKey = "0c5946fa1675b2bb65b21bdf432d101d";
        //api key https:api.edamam.com/api/recipes/v2
       
        //this is how we structure the api request
        WebClient apiConnection = new WebClient();
        string apiURL = $" https://api.edamam.com/search?app_id=0ff705b0&app_key=0c5946fa1675b2bb65b21bdf432d101d&q=";
        string searchQuery { get; set; }
        string apiEndpoint
        {
            get
            {
                return apiURL + searchQuery;
            }
        }
        public DataManager(string recipes)
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
