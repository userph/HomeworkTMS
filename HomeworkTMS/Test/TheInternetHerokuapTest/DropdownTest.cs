using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DropdownTest: BaseTest
    {


    [SetUp]
    public void Setup()
    {

       DropdownPage.OpenPageByUrl(DropdownPage.GetHerokuappDomainURL(), DropdownPage.GetEndPoint());
    }



    [Test]

        public void HW18_C_Dropdown()

        {
        
        


        for (int i = 1; i < 3; i++) 
        {
            DropdownPage.SelectDropdownItem(i);
            DropdownPage.CheckDropdownItemSelection(i);

        }
        


        }


       





    }

