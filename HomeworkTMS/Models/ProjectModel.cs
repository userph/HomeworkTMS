using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


public class ProjectModel
{
    [JsonPropertyName("id")] public int Id { get; set; }
    public string? Name { get; set; }
    public string? Announcement { get; set; }

    public int UseIndex { get; set; }

    public bool ShownTheAnnouncement { get; set; }

    public string? EnableTestCaseApprovals { get; set; }

    public string? DefaultAccess { get; set; }

    public string? DefectViewUrl { get; set; }

    public string? DefectAddUrl { get; set; }

    public string? DefectPlugin { get; set; }


    public string? ReferenceViewUrl { get; set; }

    public string? ReferenceAddUrl { get; set; }

    public string? ReferencePlugin { get; set; }



    public string? Label { get; set; }

    public string? Description { get; set; }

    public string? SystemName { get; set; }

    public string? TypeName { get; set; }

    public string? Fallback { get; set; }


    public override string ToString()
    {
        return $"{nameof(Id)} : {Id}, {nameof(Name)} : {Name}, {nameof(Announcement)} : {Announcement}";
    }


    public bool Equals(ProjectModel projectModel)

    {

        return Name == projectModel.Name && Announcement == projectModel.Announcement;


    }


}


