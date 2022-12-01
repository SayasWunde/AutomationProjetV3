using Automation_project_v3;
using Automation_project_v3.UIElements;
using Automation_project_v3.Scenarios;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
namespace Automation_project_v
{
    public class  EntryPoint
    {


        /* work only becuse "static" was added*/
        static IWebDriver driver = new ChromeDriver(); /* initialis chrome driver*/
        IAlert alert;
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }
        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfullLogin, alert.Text);
            alert.Accept();
        }
        [Test]
        public void InvalidLoginLessThen5characterinTheUsernameField()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginFormWithOutAnyData();
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidUserNameMessage, alert.Text);
            alert.Accept();
        }


        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}