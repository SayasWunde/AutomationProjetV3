using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3.UIElements
{
    public class TestScenarios_RegisterForm 
    {
        public TestScenarios_RegisterForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How =How.Name,Using = "userid") ]
        public IWebElement UserIdField { get; set; }

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.Name, Using = "address")]
        public IWebElement AddressField { get; set; }

        [FindsBy(How = How.Name, Using = "zip")]
        public IWebElement ZipCodeField { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Name, Using = "desc")]
        public IWebElement AboutField { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement RegisterButton { get; set; }

        /*DropDown Elements*/
        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select")]
        public IWebElement Country_field { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(1)")]
        public IWebElement DropDown_Element_Default { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(2)")]
        public IWebElement DropDown_Element_Australia { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(3)")]
        public IWebElement DropDown_Element_Canada { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(4)")]
        public IWebElement DropDown_Element_India { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(5)")]
        public IWebElement DropDown_Element_Russia { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(6)")]
        public IWebElement DropDown_Element_USA { get; set; }

        /*Radio button */

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(17) > input[type=radio]")]
        public IWebElement Sex_RadioButton_Female { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(16) > input[type=radio]")]
        public IWebElement Sex_RadioButton_Male { get; set; }

        /*CheckBox*/

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(19) > input[type=checkbox]")]
        public IWebElement English_CheckBox { get; set; }






    }
}
