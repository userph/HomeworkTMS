using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DynamicControlsTest: BaseTest
    {

        [SetUp]
        public void Setup()
        {

            DynamicControlsPage.OpenPageByUrl(DynamicControlsPage.GetHerokuappDomainURL(), DynamicControlsPage.GetEndPoint());
        }


    

        [Test]
        [Category("Common")]

    public void HW21_1_DynamicControls()
        
        {



        DynamicControlsPage.Checkbox();
        DynamicControlsPage.RemoveCheckbox();
  
        WaitsHelper.ExplicitlyWaitAndFindElement(15, DynamicControlsPage.Message());

        }


    




 






}
