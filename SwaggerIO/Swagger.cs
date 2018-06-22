using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace SwaggerIO
{

    public class Swagger
    {
        RestClient pet = new RestClient("https://petstore.swagger.io/v2");

        public string Get(int id)
        {
            var request = new RestRequest($"/pet/{id}", Method.GET);
            IRestResponse response = pet.Execute(request);
            string getjson = response.Content;
 //           Console.WriteLine(getjson);
            return getjson;
        }

        public string Post()
        {
            var loginRequest = new RestRequest("/pet", Method.POST);
            loginRequest.AddHeader("content-type", "application/json");
            string json = @"{
             ""id"": 0,
             ""category"": {
             ""id"": 0,
             ""name"": ""string""
                },
            ""name"": ""doggie"",
            ""photoUrls"": [
              ""string""
            ],
            ""tags"": [
                  {
               ""id"": 0,
               ""name"": ""string""
                 }
                ],
                 ""status"": ""available""
                }";

            loginRequest.AddParameter("text/json", json, ParameterType.RequestBody);
            IRestResponse response = pet.Execute(loginRequest);
            return response.Content;
        }

        public Pet GetPet(string getjson)
        {
            Pet pet = JsonConvert.DeserializeObject<Pet>(getjson);
            return pet;
        }

        public Pet PostPet(string json)
        {
            Pet pet = JsonConvert.DeserializeObject<Pet>(json);
            return pet;
        }
        
    }
}
