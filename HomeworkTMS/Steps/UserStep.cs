using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class UserStep: BaseStep
    {

    private AutorizationPage _autorizationPage;

    public UserStep(IWebDriver driver): base(driver)
    
    { 
    
    _autorizationPage = new AutorizationPage(driver);
    
    }







    public void Autorization(string username, string password)

    {


        /*

        _autorizationPage.FindInputLoginField().SendKeys(_autorizationPage.GetQacTestRailUsername());
        _autorizationPage.FindInputPasswordField().SendKeys(_autorizationPage.GetQacTestRailPassword());
        _autorizationPage.FindLoginButton().Click();

        */

        _autorizationPage.FindInputLoginField().SendKeys(username);
        _autorizationPage.FindInputPasswordField().SendKeys(password);
        _autorizationPage.FindLoginButton().Click();




    }



}

