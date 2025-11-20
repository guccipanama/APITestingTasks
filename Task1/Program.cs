using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Task1
{
    public partial class Character
    {
        public string? Name { get; set; }
        public long Height { get; set; }
        public long Mass { get; set; }
        public string? HairColor { get; set; }
        public string? SkinColor { get; set; }
        public string? EyeColor { get; set; }
        public string? BirthYear { get; set; }
        public string? Gender { get; set; }
        public string? Homeworld { get; set; }
        public List<string>? Films { get; set; }
        public List<string>? Species { get; set; }
        public List<string>? Vehicles { get; set; }
        public List<string>? Starships { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Edited { get; set; }
        public string? Url { get; set; }
    }

    public class LukeSkywalkerTask
    {
        public RestResponse GetCharacter()
        {
            var restClient = new RestClient("https://swapi.dev/");
            var restRequest = new RestRequest("/api/people/1/", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            RestResponse resp = restClient.Get(restRequest);
            return resp;
        }

        public static int Main()
        {
            var task = new LukeSkywalkerTask();
            var response = task.GetCharacter();
            var content = response.Content;
            var characterInfo = JsonConvert.DeserializeObject<Character>(content);
            characterInfo.Films.ForEach(Console.WriteLine);
            return 0;
        }
    }
}
