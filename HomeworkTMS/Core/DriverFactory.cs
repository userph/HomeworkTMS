﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


public class DriverFactory
{

    public IWebDriver GetChromeDriver()

    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument("--incognito");
        chromeOptions.AddArgument("--remote-debugging-pipe");

        new DriverManager().SetUpDriver(new ChromeConfig());

        return new ChromeDriver(chromeOptions);

    }


    public IWebDriver GetFirefoxDriver()

    {
        var firefoxOptions = new FirefoxOptions();
        firefoxOptions.AddArgument("--incognito");
       
        new DriverManager().SetUpDriver(new FirefoxConfig());

        return new FirefoxDriver(firefoxOptions);

    }

    



}