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







    public void Autorization(UserModel userModel)

    {

        _autorizationPage.FindInputLoginField().SendKeys(userModel.UserName);
        _autorizationPage.FindInputPasswordField().SendKeys(userModel.Password);
        _autorizationPage.FindLoginButton().Click();




    }



}

