using Allure.Net.Commons;
using Allure.NUnit.Attributes;

[TestFixture]
public class AddRemoveElementsTest : BaseTest

{

    [SetUp]
    public void Setup()
    {

        AddRemoveElementsPage.OpenPageByUrl(AddRemoveElementsPage.GetHerokuappDomainURL(), AddRemoveElementsPage.GetEndPoint());
    }




    [Test]
    [Category("Common")]

    public void HW18_A_Add_Remove_Elements()

    {
        

    
        for (int i = 0; i < 2; i++)
        {

        AddRemoveElementsPage.ClickToAddButton();

        }

        AddRemoveElementsPage.ClickToDeleteButton();
        AddRemoveElementsPage.CheckNumberOfElements(1);

    }




}






