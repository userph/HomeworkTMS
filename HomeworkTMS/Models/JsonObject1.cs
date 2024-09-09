using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


    public class JsonObject1
    {

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("lastName")] public string LastName { get; set; }

    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("age")] public int Age { get; set; }



    }

