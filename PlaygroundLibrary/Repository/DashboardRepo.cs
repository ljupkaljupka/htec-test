using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundLibrary.Repository
{
    public class DashboardRepo
    {
        [FindsBy(How = How.CssSelector, Using = ".dashboard")]
        protected internal IWebElement Dashboard { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='playground_card_id']")]
        protected internal IWebElement Playground { get; set; }
                
    }
}
