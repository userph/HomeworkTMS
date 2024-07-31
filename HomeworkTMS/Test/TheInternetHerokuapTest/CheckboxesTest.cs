using Allure.Net.Commons;
using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

[TestFixture]
public class Checkboxes : BaseTest

{


    [SetUp]
    public void Setup()
    {

        CheckboxesPage.OpenPageByUrl(CheckboxesPage.GetHerokuappDomainURL(), CheckboxesPage.GetEndPoint());
    }



    [Test]

    public void HW18_B_Checkboxes_FirstCheckbox()

    {

       
        CheckboxesPage.CheckSelection("IsUnchecked", 0);
        CheckboxesPage.SelectCheckbox(0);
        CheckboxesPage.CheckSelection("IsСhecked", 0);



    }


    [Test]

    public void HW18_B_Checkboxes_SecondCheckbox()

    {

       
        CheckboxesPage.CheckSelection("IsСhecked", 1);
        CheckboxesPage.SelectCheckbox(1);
        CheckboxesPage.CheckSelection("IsUnchecked", 1);

       
   

    }


}








