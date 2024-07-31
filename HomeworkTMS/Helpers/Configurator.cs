using Newtonsoft.Json;
using System.Reflection;


public class Configurator
{

    public static AppSettings ReadConfiguration()

    {
        var appSettingPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "appsettings.json");
        var appSettingsText = File.ReadAllText(appSettingPath);
        return JsonConvert.DeserializeObject<AppSettings>(appSettingsText) ?? throw new FileNotFoundException();

    }



}