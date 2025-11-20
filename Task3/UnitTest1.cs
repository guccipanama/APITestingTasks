using Newtonsoft.Json;

namespace Task3
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var task = new MorpheusLeaderTask();
            var response = task.PostUser();
            Assert.AreEqual((int)response.StatusCode, 201);
            var content = response.Content;
            var user = JsonConvert.DeserializeObject<UserResponse>(content);
            Assert.IsNotNull(user.Id);
        }
    }
}