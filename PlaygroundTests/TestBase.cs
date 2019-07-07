using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaygroundLibary.Selenium;
using PlaygroundLibary.Pages;
using OpenQA.Selenium;
using System.IO;
using PlaygroundLibrary.Pages;

namespace PlaygroundTests
{
    /// <summary>
    /// Summary description for TestBase
    /// </summary>
    [TestClass]
    public class TestBase
    {

        public LoginPage LoginPage;

        public DashboardPage DashboardPage; 

        public PlaygroundPage PlaygroundPage;

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestInitialize]
        public void Setup()
        {
            Driver.Create();
            Driver.driver.Navigate().GoToUrl("https://qa-sandbox.apps.htec.rs/");
            LoginPage = new LoginPage();
            DashboardPage = new DashboardPage();
            PlaygroundPage = new PlaygroundPage();
        }

        [TestCleanup]
        public void CleanUp()
        {
            switch (this.TestContext.CurrentTestOutcome)
            {
                case UnitTestOutcome.Failed:
                    {
                        var screenshot = (ITakesScreenshot)Driver.driver;
                        var image = screenshot.GetScreenshot();

                        var filepath = Path.Combine(Directory.GetCurrentDirectory(), String.Format("Screenshot_{0}_{1}.png", this.TestContext.TestName, DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss")));

                        image.SaveAsFile(filepath, ScreenshotImageFormat.Png);

                        //Add the screenshot to the testresults which will be published to TFS
                        this.TestContext.AddResultFile(filepath);

                        //CaptureScreenshot.CreateScreenCapture(CaptureScreenshot.GenerateRandomFilename(TestContext.TestName));
                        this.TestContext.WriteLine("Browser was closed by the MyTestCleanup() method due to a failure on the test!");
                        break;
                    }
            }
            Driver.driver.Quit();
        }
    }

}