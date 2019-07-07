using OpenQA.Selenium.Support.PageObjects;
using PlaygroundLibary.Selenium;
using PlaygroundLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlaygroundLibrary.Pages
{
    public class DashboardPage : DashboardRepo
    {
        public DashboardPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public bool IsAt()
        {
            try { return Actions.WaitForElement(Dashboard); }
            catch { return false; }
        }

        public DashboardPage OpenPlayground()
        {
            Actions.Click(Playground);
            return this;
        }
    }
}
