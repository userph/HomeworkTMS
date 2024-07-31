using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


    public class AutorizationPage: BasePage
    {

    private string _endPoint = "index.php?/auth/login/";

    public string QacTestRailUsernameValue = Configurator.ReadConfiguration().QacTestRailUsername;

    public string QacTestRailPasswordValue = Configurator.ReadConfiguration().QacTestRailPassword;


    //   private static readonly By CheckboxBy = By.CssSelector("[type = 'checkbox']");

    private static readonly By InputLoginFieldBy = By.Id("name");
    private static readonly By InputPasswordFieldBy = By.Id("password");
    private static readonly By LoginButtonBy = By.Id("button_primary");






    public AutorizationPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    public string GetQacTestRailUsername() 
    
    { 
        return QacTestRailUsernameValue;

    }


    public string GetQacTestRailPassword()
    {
        return QacTestRailPasswordValue;
    }






    private IWebElement FindInputLoginField() => Driver.FindElement(InputLoginFieldBy);
    private IWebElement FindInputPasswordField() => Driver.FindElement(InputPasswordFieldBy);
    private IWebElement FindLoginButton() => Driver.FindElement(LoginButtonBy);



    public void InputLogin(string Username) => FindInputLoginField().SendKeys(Username);
    public void InputPassword(string Username) => FindInputPasswordField().SendKeys(Username);

    public void PressLoginButton() => FindLoginButton().Click();




    public void Autorization()

    {
        OpenPageByUrl(GetQacTestRailURL(), GetEndPoint());
        InputLogin(GetQacTestRailUsername());
        InputPassword(GetQacTestRailPassword());
        PressLoginButton();

    }






}

