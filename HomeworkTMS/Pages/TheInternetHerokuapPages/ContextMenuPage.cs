using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class ContextMenuPage : BasePage
    {

        private string _endPoint = "context_menu";
        private static readonly By HotSpotBy = By.Id("hot-spot");

  
    
    




    public ContextMenuPage(IWebDriver driver) : base(driver)

        {
            Driver = driver;


        }

        public IWebDriver Driver { get; set; }


        public override string GetEndPoint()

        {
            return _endPoint;
        }



    public IWebElement FindHotspot() => Driver.FindElement(HotSpotBy);

    public string GetAllertText() => "You selected a context menu";

  
}


    



