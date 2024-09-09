using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;

namespace HomeworkTMS.Test.ApiTest
{
    public class RestSharpTest
    {

        private Logger _logger = LogManager.GetCurrentClassLogger();

        [Test]

        public void SimpleGetTest() 
        
        {

            const string endPoint = "/api/users/2";

            //Create client
            RestClient client = new RestClient(Configurator.ReadConfiguration().ReqresUrl);

            //Create request
            RestRequest request = new RestRequest(endPoint);

            //Get response

            RestResponse response = client.ExecuteGet(request); 

            _logger.Info(response.Content);

            Assert.That(response.StatusCode == HttpStatusCode.OK);

        
        }




    }
}
