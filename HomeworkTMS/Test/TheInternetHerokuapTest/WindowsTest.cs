using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WindowsTest : BaseTest
{

    [SetUp]
    public void Setup()
    {

        WindowsPage.OpenPageByUrl(WindowsPage.GetHerokuappDomainURL(), WindowsPage.GetEndPoint());
    }

    [Test]

    public void NewTabTest()

    {
        WindowsPage.ClickNewTabButton();
        WindowsPage.SwitchToTab(1);
        WindowsPage.CheckTitle("New Window");


    }


    [Test]

    public void MainTabTest()

    {
        WindowsPage.ClickNewTabButton();
        WindowsPage.SwitchToTab(0);
        WindowsPage.CheckTitle("Opening a new window");

    }




}

