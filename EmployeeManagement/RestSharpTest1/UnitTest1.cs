using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace RestSharpTest1
{
    [TestClass]
    public class UnitTest1
    {
        RestClient client;

        [TestInitialize]
        public void Setup()
        {
            client = new RestClient("http://localhost:5000");
        }
        private IRestResponse getEmployeeList()
        {
            RestRequest request = new RestRequest("/employees", Method.GET);

            //act
            IRestResponse response = client.Execute(request);
            return response;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
