using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class NavigationStep: BaseStep
    {



    public NavigationStep(IWebDriver driver): base(driver) 
    
    {
        _driver = driver;

    }
   

    public AutorizationPage NavigateToAutorizationPage()

    {
       

         return new AutorizationPage(_driver, true);



    }




}

