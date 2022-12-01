using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3
{
    public class Menu
    {
        public Menu() /*constructor for this class*/
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        /*all menu item elements ready to be used */
        [FindsBy(How = How.CssSelector, Using = "#menu-item-25 > a")]
        public IWebElement Introduction { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-106 > a")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-35 > a")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-57 > a")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-58 > a")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-26 > a")]
        public IWebElement About { get; set; }
    }
}
