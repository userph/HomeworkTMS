using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



public abstract class LcBasePage : LoadableComponent<LcBasePage>
{


    public string HerokuappDomainURL = Configurator.ReadConfiguration().HerokuappUrl;

    public string DemoqaDomainURL = Configurator.ReadConfiguration().DemoqaUrl;

    public string QacTestRailURL = Configurator.ReadConfiguration().QacTestRailUrl;

    public string FormyProjectHerokuappURL = Configurator.ReadConfiguration().FormyProjectHerokuappUrl;

    protected IWebDriver Driver { get; set; }



    //

    protected LcBasePage(IWebDriver driver, bool openPageByUrl = false)

    {

        Driver = driver;
        if (openPageByUrl ) 
        
            Load();
        

    }





    public abstract string GetEndPoint();


    public string GetHerokuappDomainURL()
    {
        return HerokuappDomainURL;
    }


    public string GetDemoqaDomainURL()
    {
        return DemoqaDomainURL;
    }



    public string GetFormyProjectHerokuappURL()

    { 
        
        return FormyProjectHerokuappURL;
    
    }

    public string GetQacTestRailURL()

    {

        return QacTestRailURL;

    }







    public IAlert SwitchToAlert()
    {
        return Driver.SwitchTo().Alert();
    }



    protected override void ExecuteLoad()

    {
        Driver.Navigate().GoToUrl(GetQacTestRailURL() + GetEndPoint());
    }




    public static string GetUploadedFileName()

    {

        return Configurator.ReadConfiguration().UploadedFileName;
    }




}