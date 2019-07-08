using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PlaygroundLibary.Config;
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
    public class PlaygroundPage : PlaygroundRepo
    {
        public PlaygroundPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public bool IsAt()
        {
            try { return Actions.WaitForElement(PeopleTab); }
            catch { return false; }
        }


        public void OpenTab(string obj)
        {
            if(obj == "Seniorities")
            {
                Actions.Click(SenioriyTab);
            }
            if(obj == "Technologies")
            {
                Actions.Click(TechnologyTab);
            }
        }
        
        public bool IsSeniorityTabOpened()
        {
            try { return CreateSenioritiesButton.Displayed; }
            catch { return false; }
        }

        public PlaygroundPage CreateSeniority(String seny)
        {
            Actions.Click(CreateSenioritiesButton);
            Actions.Enter(SeniorityName, seny);
            Session.CreatedSeniorityName = seny;
            Actions.Click(Submit);
            return this;
        }

        public bool IsCreatedSeniorityInList()
        {
            Actions.WaitForElement(CreateSenioritiesButton);
            foreach(IWebElement Seniority in List)
            {
                if (Seniority.Text.Equals(Session.CreatedSeniorityName)) { return true; }
                else { continue; }
            }
            return false;
        }

        public bool IsTechnologyTabOpened()
        {
            try { return CreateTechnologyButton.Displayed; }
            catch { return false; }
        }

        public PlaygroundPage CreateTechnology(String tech)
        {
            Actions.Click(CreateTechnologyButton);
            Actions.Enter(TechnologyName, tech);
            Session.CreatedTechnologyName = tech;
            Actions.Click(Submit);
            return this;
        }

        public bool IsCreatedTechnologyInList()
        {
            Actions.WaitForElement(CreateTechnologyButton);
            foreach (IWebElement Technology in List)
            {
                if (Technology.Text.Equals(Session.CreatedTechnologyName)) { return true; }
                else { continue; }
            }
            return false;
        }

        public PlaygroundPage OpenPeopleTab()
        {
            Actions.Click(PeopleTab);
            return this;
        }

        public bool IsPeopleTabOpened()
        {
            try { return CreatePersonButton.Displayed; }
            catch { return false; }
        }

        public PlaygroundPage CreatePerson()
        {
            Actions.Click(CreatePersonButton);
            return this;
        }

        public bool IsCreateFormOpened()
        {
            try { return FullNameField.Displayed; }
            catch { return false; }
        }

        public PlaygroundPage EnterFullName(string name)
        {
            Actions.Enter(FullNameField, name);
            Session.CreatedPersonName = name;
            return this;
        }

        public PlaygroundPage ChooseSeniorities(string sen)
        {
            Actions.Click(SeniorityInputField);
            Actions.WaitForElement(Dropdown);
            IWebElement e = Driver.driver.FindElement(By.XPath("//span[contains(text(), '" + sen + "')]"));
            Session.CreatedSeniorityName = sen;
            Actions.Click(e);
            return this;
        }

        public PlaygroundPage ChooseTehnologies(string teh)
        {
            Actions.Click(TechnologyInputField);
            Actions.WaitForElement(Dropdown);
            IWebElement e = Driver.driver.FindElement(By.XPath("//span[contains(text(), '" + teh + "')]"));
            Session.CreatedTechnologyName = teh;
            Actions.Click(e);
            return this;
        }

        public PlaygroundPage SavePerson()
        {
            Actions.Click(Submit);
            return this;
        }

        public bool IsCreatedPersonInList()
        {
            Actions.WaitForElement(CreatePersonButton);
            foreach (IWebElement Person in List)
            {
                if (Person.Text.Equals(Session.CreatedPersonName))
                {
                    Actions.Click(Person);
                    Actions.WaitForElement(ValueFromTechnologyField);
                    Actions.WaitForElement(ValueFromSeniorityField);
                    if (ValueFromTechnologyField.Text.Equals(Session.CreatedTechnologyName))
                    {
                        if (ValueFromSeniorityField.Text.Equals(Session.CreatedSeniorityName))
                        {
                            return true;
                        }
                    }
                }
                else { continue; }
            }
            return false;
        }

        public PlaygroundPage DeleteAllPersonFromList()
        {
            while(Actions.WaitForElement(FirstFromList))
            {
                Actions.Click(FirstFromList);
                Actions.WaitForElement(DeletPersonIcon);
                Actions.Click(DeletPersonIcon);
                Actions.WaitForElement(DeleteButtonInDeleteModal);
                Actions.Click(DeleteButtonInDeleteModal);
                continue;
            }
            return this;
        }

        public bool AreAllPeopleFromListDeleted()
        {
            return TextIfListIsEmpty.Displayed;
        }

        public void SwitchName()
        {
            Actions.WaitForElement(FirstFromList);
            string fullName = FirstFromList.Text;
            Session.CreatedPersonName = fullName;
            string[] firstAndLastName = fullName.Split(' ');
            string firstName = firstAndLastName[0];
            string lastName = firstAndLastName[1];
            string switchedName = lastName + ' ' + firstName;
            Actions.Click(FirstFromList);
            Actions.Enter(FullNameField, switchedName);
            Actions.WaitForElement(Submit);
            Actions.Click(Submit);
        }

        public bool IsNameSwitched()
        {
            Actions.WaitForElement(FirstFromList);
            string fullName = FirstFromList.Text;
            if (fullName.Equals(Session.CreatedPersonName)) { return false; }
            else { return true; }
        }
    }
}
