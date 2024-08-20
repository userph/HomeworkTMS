using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using NLog;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;




[Parallelizable(ParallelScope.Fixtures)]
[AllureNUnit]
public class BaseTest
{


    public IWebDriver Driver { get; set; }

    public int Timeout { get; set; }
    public AddRemoveElementsPage AddRemoveElementsPage { get; set; }
    public CheckboxesPage CheckboxesPage { get; set; }
    public DropdownPage DropdownPage { get; set; }

    public InputsPage InputsPage { get; set; }
    public TyposPage TyposPage { get; set; }

    public WindowsPage WindowsPage { get; set; }

    public DynamicControlsPage DynamicControlsPage { get; set; }

    public AlertsPage AlertsPage { get; set; }

    public FileUploadPage FileUploadPage { get; set; }

    public AddProjectPage AddProjectPage { get; set; }


    public DashboardPage DashboardPage { get; set; }

    public ProjectsOverviewPage ProjectsOverviewPage { get; set; } 

    public SubscriptionPage SubscriptionPage { get; set; }

    public AllertsHelper AllertsHelper { get; set; }

    public ComponentProcessing ComponentProcessing { get; set; }

    public ContentConfigurator ContentConfigurator { get; set; }

    public Configurator Configurator { get; set; }

    public AutorizationPage AutorizationPage { get; set; }

    public ContextMenuPage ContextMenuPage { get; set; }   
    
    public ActionsHelper ActionsHelper { get; set; }

    public WaitsHelper WaitsHelper { get; set; }

    public NavigationStep NavigationStep { get; set; }
    public UserStep UserStep { get; set; }







    [OneTimeSetUp]
    [AllureBefore("Î÷èùàåì ðåçóëüòàòû ïðåäûäóùèõ òåñòîâ.")]
    public void GlobalSetUp()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();

    }



    [SetUp]
    public void Setup()
    {

        Driver = new Browser().Driver;


        AddRemoveElementsPage = new AddRemoveElementsPage(Driver);
        CheckboxesPage = new CheckboxesPage(Driver);
        DropdownPage = new DropdownPage(Driver);
        InputsPage = new InputsPage(Driver);
        TyposPage = new TyposPage(Driver);
        WindowsPage = new WindowsPage(Driver);
        DynamicControlsPage = new DynamicControlsPage(Driver);
        AlertsPage = new AlertsPage(Driver);
        FileUploadPage = new FileUploadPage(Driver);    
        AddProjectPage = new AddProjectPage(Driver);
        DashboardPage = new DashboardPage(Driver);
        ProjectsOverviewPage = new ProjectsOverviewPage(Driver);
        AllertsHelper = new AllertsHelper(Driver);
        ComponentProcessing = new ComponentProcessing(Driver);
        ContentConfigurator = new ContentConfigurator();
        Configurator = new Configurator();
        AutorizationPage = new AutorizationPage(Driver);
        ContextMenuPage = new ContextMenuPage(Driver);
        ActionsHelper = new ActionsHelper(Driver);
        WaitsHelper = new WaitsHelper(Driver, Timeout);
        SubscriptionPage = new SubscriptionPage(Driver);
        NavigationStep = new NavigationStep(Driver);
        UserStep = new UserStep(Driver);
    }

    [TearDown]

    [AllureAfter("Çàêðûâàåì áðàóçåð.")]
    public void TearDown()
    {


        if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)

        {
            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] screenshotByte = screenshot.AsByteArray;
            AllureApi.AddAttachment("screenshot", "image/png", screenshotByte);

        }

        Driver.Dispose();


    }

}