using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Task2
{
    public partial class PageData
    {
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public List<UserData>? Data { get; set; }
        public Support? Support { get; set; }
        public Meta? Meta { get; set; }
    }

    public partial class UserData
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? Avatar { get; set; }
    }

    public partial class Meta
    {
        public string? PoweredBy { get; set; }
        public string? UpgradeUrl { get; set; }
        public string? DocsUrl { get; set; }
        public string? TemplateGallery { get; set; }
        public string? Message { get; set; }
        public List<string>? Features { get; set; }
        public string? UpgradeCta { get; set; }
    }

    public partial class Support
    {
        public string? Url { get; set; }
        public string? Text { get; set; }
    }

    public class GeorgeEdwardsTask
    {
        public RestResponse GetUser()
        {
            var restClient = new RestClient("https://reqres.in");
            var restRequest = new RestRequest("/api/users?page=2", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            RestResponse resp = restClient.Get(restRequest);
            return resp;
        }

        public static int Main()
        {
            var task = new GeorgeEdwardsTask();
            var response = task.GetUser();
            var content = response.Content;
            var page = JsonConvert.DeserializeObject<PageData>(content);
            var userData = page.Data;
            for (int i = 0; i < userData.Count; i++)
            {
                if (userData[i].first_name == "George" && userData[i].last_name == "Edwards")
                    Console.WriteLine(userData[i].Email);
            }
            return 0;
        }
    }
}
