using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


    public class AutorizationPage: LcBasePage
    {


    public AutorizationPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)

    {

       Driver = driver;
    }

    private string _endPoint = "index.php?/auth/login/";

    public string QacTestRailUsernameValue = Configurator.ReadConfiguration().QacTestRailUsername;

    public string QacTestRailPasswordValue = Configurator.ReadConfiguration().QacTestRailPassword;


    //   private static readonly By CheckboxBy = By.CssSelector("[type = 'checkbox']");

    private static readonly By InputLoginFieldBy = By.Id("name");
    private static readonly By InputPasswordFieldBy = By.Id("password");
    private static readonly By LoginButtonBy = By.Id("button_primary");









 //   public IWebDriver Driver { get; set; }


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






    public IWebElement FindInputLoginField() => Driver.FindElement(InputLoginFieldBy);
    public IWebElement FindInputPasswordField() => Driver.FindElement(InputPasswordFieldBy);
    public IWebElement FindLoginButton() => Driver.FindElement(LoginButtonBy);



    /*Перенос в Steps

    public void InputLogin(string Username) => FindInputLoginField().SendKeys(Username);
    public void InputPassword(string Username) => FindInputPasswordField().SendKeys(Username);

    public void PressLoginButton() => FindLoginButton().Click();




    public void Autorization()

    {
       
        InputLogin(GetQacTestRailUsername());
        InputPassword(GetQacTestRailPassword());
        PressLoginButton();

    }


    */

    protected override bool EvaluateLoadedStatus()
    {

        return FindLoginButton().Displayed;
        
        
    }









}

