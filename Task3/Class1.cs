using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Task3
{
    public partial class UserRequest
    {
        public string Name { get; set; }
        public string Job { get; set; }
    }
    public partial class UserResponse
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public string? Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class MorpheusLeaderTask
    {
        public RestResponse PostUser()
        {
            var restClient = new RestClient("https://reqres.in");
            var restRequest = new RestRequest("/api/users", Method.Post);
            var morpheus = new UserRequest { Name = "morpheus", Job = "leader" };
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("x-api-key", "reqres-free-v1");
            restRequest.AddParameter("application/json", JsonConvert.SerializeObject(morpheus), ParameterType.RequestBody);
            restRequest.RequestFormat = DataFormat.Json;
            RestResponse resp = restClient.Post(restRequest);
            return resp;
        }
    }
}
