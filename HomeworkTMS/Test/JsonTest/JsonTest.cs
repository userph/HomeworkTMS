using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;


internal class JsonTest
    {

    [Test]
    public void SerializeTest()
    {

        var json = new JsonObject1()

        {

            Name = "Test Name",
            LastName = "Test Last Name",
            Id = 76,
            Age = 30


        };

        var jsonAsString = JsonSerializer.Serialize<JsonObject1>(json);
        Console.WriteLine(jsonAsString);
    }

    [Test]
    public void DeserializeTest()
    {

        var jsonAsString = " {\"Name\":\"Test2\",\"Id\":123}"; 

        JsonObject1 jsonObject = JsonSerializer.Deserialize<JsonObject1>(jsonAsString);
        Console.WriteLine(jsonObject.Name);
        Console.WriteLine(jsonObject.Id);
    }


    [Test]
    public void FileStreamTest()
    {

        using FileStream fs = new FileStream(@"Resources/testObject1.json", FileMode.Open);
        JsonObject1 jsonObject = JsonSerializer.Deserialize<JsonObject1>(fs);
        Console.WriteLine(jsonObject.Name);
        Console.WriteLine(jsonObject.Id);

    }



}

