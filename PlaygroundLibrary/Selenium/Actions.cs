using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace PlaygroundLibary.Selenium
{
    public class Actions
    {
        public static bool Click(IWebElement obj)
        {
            if(CheckIfClickable(obj))
            {
                try
                {
                    obj.Click();
                    return true;
                }
                catch 
                {
                    return false;
                }
            }
            else { return false; }
        }

        public static bool CheckIfClickable(IWebElement obj)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
                IWebElement e = wait.Until(ExpectedConditions.ElementToBeClickable(obj));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Enter(IWebElement e, string text)
        {
            if (CheckIfClickable(e))
            {
                try
                {
                    e.Clear();
                    Thread.Sleep(500);
                    e.SendKeys(text);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool WaitForElement(IWebElement obj)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
                return wait.Until(d => obj.Displayed);
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
