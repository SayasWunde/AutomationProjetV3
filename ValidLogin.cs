using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation_project_v3.Scenarios
{
    public class ValidLogin
    {
        IAlert alert;
        public ValidLogin()
        {
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughTheMenu();
        }
        [Test]
        public void ValidLoginTest()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.UserName,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfullLogin, alert.Text);
            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
