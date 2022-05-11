using RestSharp;
using Xunit;

namespace ApiTests
{
    public class ContentTests
    {

        [Fact(DisplayName = "Api Content Check For Posts")]
        public void ShouldCheckContentForPosts()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/posts");
            RestRequest request = new RestRequest(Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.NotEmpty(response.Content);
            
        }

        [Fact(DisplayName = "Api Content Check For Comments")]
        public void ShouldCheckContentForComments()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/comments");
            RestRequest request = new RestRequest(Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.NotEmpty(response.Content);
        }

        [Fact(DisplayName = "Api Content Check For Photos")]
        public void ShouldCheckContentCheckForPhotos()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/photos");
            RestRequest request = new RestRequest(Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.NotEmpty(response.Content);
        }

        [Fact(DisplayName = "Api Content Check For Post Id")]
        public void ShouldCheckContentCheckForPostId()
        {
            //Arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/comments?postId=1");
            RestRequest request = new RestRequest(Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.NotEmpty(response.Content);
        }

    }
}
