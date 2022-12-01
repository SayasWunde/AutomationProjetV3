using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3.UIElements
{
    public class TestCases
    {
        public TestCases()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement ItemInCategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement LogInButtonInLoginForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div/header/h3/a")]
        public IWebElement UsernameFieldInLogInForm { get; set; }



    }
}
