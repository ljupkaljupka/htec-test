using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundLibrary.Repository
{
    public class PlaygroundRepo
    {
        [FindsBy(How = How.XPath, Using = "//a[@href='/seniorities']")]
        protected internal IWebElement SenioriyTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/create-seniority']")]
        protected internal IWebElement CreateSenioritiesButton { get; set; }

        [FindsBy(How = How.Name, Using = "seniority_title")]
        protected internal IWebElement SeniorityName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div[2]/div/div/div/div/form/button")]
        protected internal IWebElement SubmitSeniorityButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/technologies']")]
        protected internal IWebElement TechnologyTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/create-technology']")]
        protected internal IWebElement CreateTechnologyButton { get; set; }

        [FindsBy(How = How.Name, Using = "technology_title")]
        protected internal IWebElement TechnologyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div[2]/div/div/div/div/form/button")]
        protected internal IWebElement SubmitTechnologyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/people']")]
        protected internal IWebElement PeopleTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/create-person']")]
        protected internal IWebElement CreatePersonButton { get; set; }

        [FindsBy(How = How.Name, Using = "people_name")]
        protected internal IWebElement FullNameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".react-dropdown-select-dropdown.react-dropdown-select-dropdown-position-bottom.css-1v2usbe-DropDown.e1qjn9k90")]
        protected internal IWebElement Dropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div[2]/div/div/div/div/form/button")]
        protected internal IWebElement SubmitPersonButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div[2]/div/div/div/form/div[3]/div/div/div[1]/span")]
        protected internal IWebElement ValueFromSeniorityField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div[2]/div/div/div/form/div[2]/div/div/div[1]/span/span[1]")]
        protected internal IWebElement ValueFromTechnologyField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Select technologies']")]
        protected internal IWebElement TechnologyInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Select seniority']")]
        protected internal IWebElement SeniorityInputField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".list-group-item.list-group-item-action")]
        protected internal IList <IWebElement>  List { get; set; }

        [FindsBy(How = How.ClassName, Using = "muted-text")]
        protected internal IWebElement TextIfListIsEmpty { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".far.fa-trash-alt")]
        protected internal IWebElement DeletPersonIcon { get; set; }

    }
}


