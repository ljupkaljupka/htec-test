using PlaygroundLibary.Config;
using PlaygroundLibary.Repository;
using PlaygroundLibary.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PlaygroundLibary.Pages
{
    public class LoginPage : LoginRepo

    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public bool IsAt()
        {
            try { return LoginButton.Displayed; }
            catch { return false; }
        }

        public LoginPage ClickLoginButton()
        {
            Actions.Click(LoginButton);
            return this;
        }

        public LoginPage EnterUsername(String name)
        {
            Actions.Enter(UsernameField, name);
            return this;
        }

        public LoginPage EnterPassword(String name)
        {
            Actions.Enter(PasswordField, name);
            return this;
        }

        public LoginPage ClickSubmitButton()
        {
            Actions.Click(SubmitButton);
            return this;
        }

        public LoginPage Login()
        {
            ClickLoginButton();
            EnterUsername("ljupka.t85@gmail.com");
            EnterPassword("ljupkahtec");
            ClickSubmitButton();
            return this;
        }

    }
}
