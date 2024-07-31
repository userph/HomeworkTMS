using AngleSharp.Text;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


    public class FileUploadTest: BaseTest
    {


    [SetUp]
    public void Setup()
    {

        FileUploadPage.OpenPageByUrl(FileUploadPage.GetFormyProjectHerokuappURL(), FileUploadPage.GetEndPoint());
    }


    [Test]

    public void UploadTest()

    {

        FileUploadPage.UploadFile();
        FileUploadPage.CompareFileName(FileUploadPage.GetActualFileName(), FileUploadPage.GetUploadedFileName());



    }










}

