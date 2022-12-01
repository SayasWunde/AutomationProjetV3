using Automation_project_v3.UIElements;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Automation_project_v3
{
    public static class Actions
    {

        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
        public static void FillLoginForm(string username , string password , string repeatPassword)
        {
            TestScenarios_LoginForm lFPost = new TestScenarios_LoginForm();
            lFPost.UserNameField.Clear();
            lFPost.PasswordField.Clear();
            lFPost.RepeatPasswordField.Clear();
            lFPost.UserNameField.SendKeys(username);
            lFPost.PasswordField.SendKeys(password);
            lFPost.RepeatPasswordField.SendKeys(repeatPassword);
            lFPost.LoginButton.Click();

        }
        public static void FillLoginFormWithOutAnyData()
        {
            TestScenarios_LoginForm lFPost = new TestScenarios_LoginForm();
            lFPost.UserNameField.Clear();
            lFPost.PasswordField.Clear();
            lFPost.RepeatPasswordField.Clear();
            lFPost.LoginButton.Click();
        }

    }
}
