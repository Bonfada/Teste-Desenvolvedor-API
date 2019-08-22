
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using WinApp.Model;

namespace WinApp.Controler
{
    public class Contoler
    {
        public bool IsSuccess { get; set; }

        public string Process(string City)
        {
            string dataObjects = "";

            using (var client = new HttpClient(new HttpClientHandler { UseProxy = false }))
            {
                string[] endpoint = Config.GetEndPoint(City);
                client.BaseAddress = new Uri(endpoint[0].ToString());
                client.Timeout = new TimeSpan(0, 0, 5);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(endpoint[1].ToString(), HttpCompletionOption.ResponseHeadersRead).Result;

                if (response.IsSuccessStatusCode)
                {
                    IsSuccess = true;
                    dataObjects = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    IsSuccess = false;
                    dataObjects = response.ToString();
                }

                return dataObjects;
            }
        }
        public Rootobject Deserialaized(string Json)
        {
            return JsonConvert.DeserializeObject<Rootobject>(Json);
        }
        
    }
}
