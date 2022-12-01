using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3.UIElements
{
    class TestCases_UsernameFieldInLoginForm
    {
        public TestCases_UsernameFieldInLoginForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How =How.CssSelector,Using ="#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }


    }
}
