using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

    public class HttpClientTest
    {

    [Test]
    public async Task SimpleHttpTest() 
    {
        const string baseUrl = "https://reqres.in/";
        using (HttpClient client = new HttpClient()) 
        {

            try
            {

                // настраиваем и выполняем GET запрос

                var response = await client.GetAsync(baseUrl);

                if (response.StatusCode == HttpStatusCode.OK)

                {
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }

            }

            catch (Exception ex) 
            
            {
                Console.WriteLine(ex);
                throw;
            
            
            }

        
        
        }

    }



    }

