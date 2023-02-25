using Newtonsoft.Json.Linq;
using System;
using System.Xml.Linq;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<string> GetWeatherByCityAsync(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://api.weatherapi.com/v1/forecast.json?key=39f8ecaf506c4f76b3f55139222906&q={city}&days=1&api=yes&alerts=yes");
                response.EnsureSuccessStatusCode();
                string stringResult = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(stringResult);
                string temp_c = json["current"]["temp_c"].ToString();
                string condition = json["current"]["condition"]["text"].ToString();
                return $"The weather in {city} is: temp {temp_c}, condition {condition}";
            }
        }
        public async Task<string> GetWeatherFor3DaysByCityAsynce(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://api.weatherapi.com/v1/forecast.json?key=39f8ecaf506c4f76b3f55139222906&q={city}&days=3&api=yes&alerts=yes9");
                response.EnsureSuccessStatusCode();
                var stringResult = await response.Content.ReadAsStringAsync();
                return stringResult;
            }
        }
    }
}
