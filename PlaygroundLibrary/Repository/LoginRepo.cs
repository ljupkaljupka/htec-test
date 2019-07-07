using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PlaygroundLibary.Repository
{
    public class LoginRepo
    {
        [FindsBy(How = How.CssSelector, Using = ".btn.btn-lg.btn-secondary")]
        protected internal IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email Address']")]
        protected internal IWebElement UsernameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        protected internal IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='submit_btn']")]
        protected internal IWebElement SubmitButton { get; set; }
    }
}
