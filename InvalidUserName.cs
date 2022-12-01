
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation_project_v3.Scenarios
{
    public class InvalidUserName
    {
        IAlert alert;
        public InvalidUserName()
        {
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughTheMenu();
        }
        [Test]
        public void InValidUsernameLessThen5Characters()
        {
            Actions.FillLoginForm(Config.Credentials.InValid.UserName.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidUserNameMessage, alert.Text);
            alert.Accept();
        }
        [Test]
        public void InValidUsernameMoreThen12Characters()
        {
            Actions.FillLoginForm(Config.Credentials.InValid.UserName.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidUserNameMessage, alert.Text);
            alert.Accept();
        }
        [Test]
        public void InValidLoginAllFieldEmpty()
        {
            Actions.FillLoginFormWithOutAnyData();
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidUserNameMessage, alert.Text);
            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
