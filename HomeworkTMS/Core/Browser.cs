using OpenQA.Selenium;




public class Browser
{
    public IWebDriver? Driver { get; set; }

    public Browser()

    {

        Driver = Configurator.ReadConfiguration().BrowserType.ToLower() switch

        {
            "chrome" => new DriverFactory().GetChromeDriver(),
            "firefox" => new DriverFactory().GetFirefoxDriver(),
            _ => throw new Exception("Данный браузер не поддерживается.")


        };


        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Configurator.ReadConfiguration().TimeOut);
        Driver.Manage().Window.Maximize();
    }





}