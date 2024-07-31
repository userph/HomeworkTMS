
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class InputsTest: BaseTest
    {


        [SetUp]
        public void Setup()
        {


        InputsPage.OpenPageByUrl(InputsPage.GetHerokuappDomainURL(), InputsPage.GetEndPoint());

        }






        [Test]

        public void HW18_D_Inputs_Int()

        {



            InputsPage.EnteringValue("123");
            InputsPage.ValueChecking("123");



        }

        [Test]
        public void HW18_D_Inputs_Int_Up()

        {



            InputsPage.EnteringValue("123");
            InputsPage.ValueIncreasing();
            InputsPage.ValueChecking("124");
    


        }

        [Test]
        public void HW18_D_Inputs_Int_Down()

        {



            InputsPage.EnteringValue("123");
            InputsPage.ValueDecrease();
            InputsPage.ValueChecking("122");



        }



        [Test]
        public void HW18_D_Inputs_String()

        {



            InputsPage.EnteringValue("abc");
            InputsPage.ValueChecking("");



        }




    }

