using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
using FlowerStoreAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using FlowerStoreAPI.Profiles;

namespace FlowerStoreAPI.Controllers
{
    /*
    using System.Text.Json;
    using System.Text.Json.Serialization;
    
    static readonly HttpClient client = new HttpClient();
    static async Task Main(){
        String url = "https://api.basisregisters.vlaanderen.be/v1/adressen/";
 
        int huisnummer =""
        String straatnaam =""
        int postcode =""

      try
      {
         HttpResponseMessage response = await client.GetAsync(url, huisnummer,straatnaam, postcode );
         response.EnsureSuccessStatusCode();
         string responseBody = await response.Content.ReadAsStringAsync();


         Console.WriteLine(responseBody);

            public string volledigAdres { get; set; }
      }
      catch(HttpRequestException e)
      {
        public string detail { get; set; }
         Console.WriteLine("\nException Caught!");
         Console.WriteLine("Message :{0} ",e.Message);
      }
    */
}