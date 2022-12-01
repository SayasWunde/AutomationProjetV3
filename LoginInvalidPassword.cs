using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation_project_v3.Scenarios
{
    public class LoginInvalidPassword
    {
        IAlert alert;
        public LoginInvalidPassword()
        {
        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughTheMenu();
        }
        [Test]
        public void InvalidPasswordLessThen5Characters()
        {
           
            Actions.FillLoginForm(Config.Credentials.Valid.UserName,Config.Credentials.InValid.Password.InValidFourCharacters,
            Config.Credentials.InValid.Password.InValidFourCharacters);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidPasswordMessage, alert.Text);
            alert.Accept();
        }
        [Test]
        public void InvalidPasswordMoreThen12Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.UserName,Config.Credentials.InValid.Password.InValidThirteenCharacters,
            Config.Credentials.InValid.Password.InValidThirteenCharacters);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidPasswordMessage, alert.Text);
            alert.Accept();
        }
        [Test]
        public void InvalidPasswordDoNotMatch()
        { 
            Actions.FillLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Valid.UserName,
            Config.Credentials.InValid.Password.InValidThirteenCharacters);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidPasswordDoNotMatch, alert.Text);
            alert.Accept();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
