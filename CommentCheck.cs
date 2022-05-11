using Newtonsoft.Json;
using RestSharp;
using Xunit;

namespace JsonPlaceholderApi
{

    public class CommentCheck
    {
        [Fact(DisplayName ="Check number of comments")]
        public void ShouldCheckNumberOfJsonComments()
        {
            ////Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/comments?postId=1");
            RestRequest request = new RestRequest(Method.GET);

            ////Act
            IRestResponse response = client.Execute(request);

            var objectsResponse = JsonConvert.DeserializeObject<Class1[]>(response.Content);


            //Assert
            Assert.Equal(5, objectsResponse.Length);
            
        }

    }
}
