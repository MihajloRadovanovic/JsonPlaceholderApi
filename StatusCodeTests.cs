using RestSharp;
using System.Net;
using Xunit;


namespace JsonPlaceholderApi
{
    public class StatusCodeTest
    {

        [Fact(DisplayName = "Api Test Http Status Code OK For Posts")]
        public void ShouldGetHttpStatusCodeOkForPosts()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/posts");
            RestRequest request = new RestRequest(Method.GET);

            //Act 
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        
        [Fact(DisplayName = "Api Test Http Status Code OK For Comments")]
        public void ShouldGetHttpStatusCodeOkForComments()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/comments");
            RestRequest request = new RestRequest(Method.GET);

            //Act 
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact(DisplayName = "Api Test Http Status Code OK For Photos")]
        public void ShouldGetHttpStatusCodeOkForPhotos()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/photos");
            RestRequest request = new RestRequest(Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact(DisplayName = "Api Test Http Status Code OK For PostId")]
        public void ShouldGetHttpStatusCodeForPostId()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/comments?postId=1");
            RestRequest request = new RestRequest(Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}





