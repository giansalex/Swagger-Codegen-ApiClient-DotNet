/* 
 * Swagger Generator
 *
 * This is an online swagger codegen server.  You can find out more at https://github.com/swagger-api/swagger-codegen or on [irc.freenode.net, #swagger](http://swagger.io/irc/).
 *
 * OpenAPI spec version: 2.2.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;
using IO.Swagger.Api;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ClientsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ClientsApiTests
    {
        private ClientsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ClientsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ClientsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ClientsApi
            //Assert.IsInstanceOfType(typeof(ClientsApi), instance, "instance is a ClientsApi");
        }

        
        /// <summary>
        /// Test ClientOptions
        /// </summary>
        [Test]
        public void ClientOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ClientOptions();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test DownloadFile
        /// </summary>
        [Test]
        public void DownloadFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //var response = instance.DownloadFile(fileId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GenerateClient
        /// </summary>
        [Test]
        public void GenerateClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //Body body = null;
            //var response = instance.GenerateClient(language, body);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test GetClientOptions
        /// </summary>
        [Test]
        public void GetClientOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //var response = instance.GetClientOptions(language);
            //Assert.IsInstanceOf<Dictionary<string, InlineResponse200>> (response, "response is Dictionary<string, InlineResponse200>");
        }
        
    }

}
