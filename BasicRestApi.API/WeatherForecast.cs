using System;

namespace BasicRestApi.API
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
//werkt niet

using System.Text.Json;
using System.Text.Json.Serialization;
 using app.UseRouting();
//ik weet niet wat dit doet 

//controller steken

  
} 
static readonly HttpClient client = new HttpClient();
[Route("https://api.basisregisters.vlaanderen.be/v1/adressen/")]
//zoekt api
class controller :

   
   

  //antwoord juist
  try
  {
    [HttpGet]
  void Get(int huisnummer, String straatnaam, int postcode) {} 

     response.EnsureSuccessStatusCode();
     string responseBody = await response.Content.ReadAsStringAsync();


     Console.WriteLine(responseBody);

        public string volledigAdres { get; set; }
  }
//antwoord fout
  catch(HttpRequestException e)
  {
    public string detail { get; set; }
     Console.WriteLine("\nException Caught!");
     Console.WriteLine("Message :{0} ",e.Message);
  }

}