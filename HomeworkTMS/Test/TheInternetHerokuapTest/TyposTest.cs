using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Filters;


public class TyposTest: BaseTest
    {

    private Logger logger;




        [SetUp]
        public void Setup()
        {


        TyposPage.OpenPageByUrl(TyposPage.GetHerokuappDomainURL(), TyposPage.GetEndPoint());

        logger = LogManager.GetCurrentClassLogger();
        }


        [Test]
        [Category("RandomError")]

    public void HW18_F_Typos()

        {

            try

            {
                TyposPage.CheckWrongEntryAbsence("won,t.");

            }

            catch (Exception ex)

            {

            logger.Error("Ошибка в тексте.");



            }





            

        



 


    }
}
