using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3.UIElements
{
    class TestScenarios
    {
        public TestScenarios()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How =How.XPath,Using = "//*[@id=\"main-content\"]/article[1]/div/header/h3/a")]
        public IWebElement LogInForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div/header/h3/a")]
        public IWebElement RegisterForm { get; set; }

    }
}
