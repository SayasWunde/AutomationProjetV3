using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3.UIElements
{
    public class TestScenarios_LoginForm
    {
        public TestScenarios_LoginForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement UserNameField {get; set;}

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement PasswordField { get; set; }


        [FindsBy(How = How.Name, Using = "repeatpassid")]
        public IWebElement RepeatPasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement LoginButton { get; set; }




    }
}
