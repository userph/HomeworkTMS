using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using AngleSharp.Dom;



public class WaitsHelper
{

    private IWebDriver _driver { get; set; }
    private WebDriverWait _wait;
    private TimeSpan _timeout { get; set; }


    public WaitsHelper(IWebDriver driver)
    {
         _driver = driver;
        _timeout = TimeSpan.FromSeconds(Configurator.ReadConfiguration().TimeOut);
        _wait = new WebDriverWait(driver, _timeout);
    }
    public WaitsHelper(IWebDriver driver, int timeoutSeconds)
    {
        _driver = driver;
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutSeconds));
       
    }


    private void DisablingImplicitWait()
    {
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
    }


    private void EnablingImplicitWait()
    {
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Configurator.ReadConfiguration().TimeOut);
    }


     


    public void ExplicitlyWaitAndFindElement(int timeoutSeconds, By Locator)
    {
        DisablingImplicitWait();
        _wait.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
        _wait.Until(ExpectedConditions.ElementIsVisible(Locator));
        EnablingImplicitWait();

    }




    public void ExplicitlyWaitAllert(int timeoutSeconds)
    {
        DisablingImplicitWait();
        _wait.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
        _wait.Until(ExpectedConditions.AlertIsPresent());
        EnablingImplicitWait();

    }




    public IWebElement WaitForVisibility(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
    }

    public bool WaitForElementInvisible(By locator)
    {
        return _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
    }

    public bool WaitForElementInvisible(IWebElement element)
    {
        try
        {
            _wait.Until(d => !element.Displayed);
            return true;
        }
        catch (NoSuchElementException)
        {
            return true;
        }
        catch (WebDriverTimeoutException)
        {
            throw new WebDriverTimeoutException($"Element visible after {_timeout} seconds");
        }
    }

    public IWebElement WaitForExist(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementExists(locator));
    }

    public IReadOnlyCollection<IWebElement> WaitForElementsPresence(By locator)
    {
        return _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
    }
}






