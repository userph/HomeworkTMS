using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



    public class ContentConfigurator
    {


        public static AddProjectData ReadConfiguration()

        {
            var appSettingPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "addprojectdata.json");
            var appSettingsText = File.ReadAllText(appSettingPath);
            return JsonConvert.DeserializeObject<AddProjectData>(appSettingsText) ?? throw new FileNotFoundException();

        }





    }

