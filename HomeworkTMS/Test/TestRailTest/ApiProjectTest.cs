using NLog;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Text.Json;




public class ApiProjectTest
    {


    private Logger _logger = LogManager.GetCurrentClassLogger();

    [Test]
    public void SimpleGetTest() 
    {


        const string endPoint = "/index.php?/api/v2/get_user/1";
        RestClientOptions restOption = new RestClientOptions(Configurator.ReadConfiguration().QacTestRailUrl)

        {

            Authenticator = new HttpBasicAuthenticator(
                
                Configurator.ReadConfiguration().QacTestRailUsername,
                Configurator.ReadConfiguration().QacTestRailPassword
            
            )

        };


        RestClient client = new RestClient(restOption);

        RestRequest request = new RestRequest(endPoint);



        //Get response
        RestResponse response = client.ExecuteGet(request);

        _logger.Info(response.Content);

        Assert.That(response.StatusCode == HttpStatusCode.OK);


    }



    [Test]
    public void AdvancedGetTest()
    {


        const string endPoint = "/index.php?/api/v2/get_user/{user_id}";
        RestClientOptions restOption = new RestClientOptions(Configurator.ReadConfiguration().QacTestRailUrl)

        {

            Authenticator = new HttpBasicAuthenticator(

                Configurator.ReadConfiguration().QacTestRailUsername,
                Configurator.ReadConfiguration().QacTestRailPassword

            )

        };


        RestClient client = new RestClient(restOption);

        RestRequest request = new RestRequest(endPoint);
        request.AddUrlSegment("user_id", 1);



        //Get response
        RestResponse response = client.ExecuteGet(request);

        _logger.Info(response.Content);

        Assert.That(response.StatusCode == HttpStatusCode.OK);


    }




    [Test]
    public void SimplePostTest() 
    
    {

        const string endPoint = "index.php?/api/v2/add_project";
        Dictionary<string, object> json = new Dictionary<string, object>();
        json.Add("name", "ApiPhilipProject");
        json.Add("announcement", "test");
        json.Add("show_announcement", true);
        json.Add("suite_mode", 1);


        RestClientOptions restOption = new RestClientOptions(Configurator.ReadConfiguration().QacTestRailUrl)

        {

            Authenticator = new HttpBasicAuthenticator(

        Configurator.ReadConfiguration().QacTestRailUsername,
        Configurator.ReadConfiguration().QacTestRailPassword

    )

        };


        RestClient client = new RestClient(restOption);

        RestRequest request = new RestRequest(endPoint)
            .AddJsonBody(JsonSerializer.Serialize(json));

        //Get response
        RestResponse response = client.ExecutePost(request);

        _logger.Info(response.Content);


        dynamic responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
        var projectId = responseObject.id;

        _logger.Info($"Project ID is: {projectId}");

        Assert.That(response.StatusCode == HttpStatusCode.OK);






    }




    [Test]

    public void AdvancedPostTest()

    {
        const string endPoint = "index.php?/api/v2/add_project";

        ProjectModel expectedProject = new ProjectModel()
        {

            Name = "AdvancedApiPhilipProject2",
            Announcement = "test",
            ShownTheAnnouncement = true,
            UseIndex = 1
        };


        RestClientOptions restOption = new RestClientOptions(Configurator.ReadConfiguration().QacTestRailUrl)

        {

            Authenticator = new HttpBasicAuthenticator(

    Configurator.ReadConfiguration().QacTestRailUsername,
    Configurator.ReadConfiguration().QacTestRailPassword

)

        };


        RestClient client = new RestClient(restOption);
        RestRequest request = new RestRequest(endPoint).AddJsonBody(expectedProject);

        var response = client.ExecutePost<ProjectModel>(request);
        var actualProject = response.Data;

        Assert.That(expectedProject.Name, Is.EqualTo(actualProject.Name));

        _logger.Info(response.Content);
        _logger.Info(actualProject.Id);

        Assert.Multiple(() =>

        {
            Assert.That(response.StatusCode == HttpStatusCode.OK);
            Assert.That(expectedProject.Equals(actualProject));
        }

        );


    }

        }
    








