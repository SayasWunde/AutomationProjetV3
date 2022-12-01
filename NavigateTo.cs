using Automation_project_v3.UIElements;
using OpenQA.Selenium;
using System.Threading;
namespace Automation_project_v3
{
    public static class NavigateTo
    {
        /*Creating function to navigate in the website*/
        public static void LoginFormThroughTheMenu ()
        {
            Menu menu = new Menu();
            TestScenarios testscenarios = new TestScenarios();
            menu.TestScenarios.Click();
            testscenarios.LogInForm.Click();
        }
        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCases testcases = new TestCases();
            TestCases_UsernameFieldInLoginForm userNameFieldPost = new TestCases_UsernameFieldInLoginForm();
            menu.TestCases.Click();
            testcases.UsernameFieldInLogInForm.Click();
            userNameFieldPost.LoginFormLink.Click();
        }
        /*SelectorsTab*/
        public static void SelectorsNamePost()
        {
            Menu menu = new Menu();
            Selectors selectors = new Selectors();
            menu.Selectors.Click();
            selectors.Name.Click();
        }
        public static void SelectorsIdPost()
        {
            Menu menu = new Menu();
            Selectors selectors = new Selectors();
            menu.Selectors.Click();
            selectors.Id.Click();
        }
        public static void SelectorsXpathPost()
        {
            Menu menu = new Menu();
            Selectors selectors = new Selectors();
            menu.Selectors.Click();
            selectors.Xpath.Click();
        }
        public static void SelectorsCssPathPost()
        {
            Menu menu = new Menu();
            Selectors selectors = new Selectors();
            menu.Selectors.Click();
            selectors.CssPath.Click();
        }
        public static void SelectorsClassNamePost()
        {
            Menu menu = new Menu();
            Selectors selectors = new Selectors();
            menu.Selectors.Click();
            selectors.ClassName.Click();
        }
        /*SpecialElementsTab*/
        public static void SpecialElementsAlertBoxPost()
        {
            IAlert alert;
            Menu menu = new Menu();
            SpecialElements specialElements = new SpecialElements();
            menu.SpecialElements.Click();
            specialElements.AlertBox.Click();
            alert = Driver.driver.SwitchTo().Alert();
            alert.Accept();
        }
        public static void SpecialElementsTextInputFieldPost()
        {
            Menu menu = new Menu();
            SpecialElements specialElements = new SpecialElements();
            menu.SpecialElements.Click();
            specialElements.TextInputField.Click();
            
        }
        public static void SpecialElementsCheckButtonTestPost()
        {
            Menu menu = new Menu();
            SpecialElements specialElements = new SpecialElements();
            menu.SpecialElements.Click();
            specialElements.CheckButtonTest.Click();
        }
        public static void SpecialElementsRadioButtonTestPost()
        {
            Menu menu = new Menu();
            SpecialElements specialElements = new SpecialElements();
            menu.SpecialElements.Click();
            specialElements.RadioButtonTest.Click();
        }
        public static void SpecialElementsDropDownMenuTestPost()
        {
            Menu menu = new Menu();
            SpecialElements specialElements = new SpecialElements();
            menu.SpecialElements.Click();
            specialElements.DropDwonMenuTest.Click();
        }
        /*TestCasesTab*/
        public static void TestCasesItemsInCategoryDropDownMenuPost()
        {
            Menu menu = new Menu();
            TestCases testcases = new TestCases();
            menu.TestCases.Click();
            testcases.ItemInCategory.Click();
            
        }
        public static void TestCasesLoginButtoninLoginFormPost()
        {
            Menu menu = new Menu();
            TestCases testcases = new TestCases();
            menu.TestCases.Click();
            testcases.LogInButtonInLoginForm.Click();
            
        }
        public static void TestCasesUsernameFieldinLoginFormPost()
        {
            Menu menu = new Menu();
            TestCases testcases = new TestCases();
            menu.TestCases.Click();
            testcases.UsernameFieldInLogInForm.Click();
        }
        /*TestScenariosTab*/
        public static void TestScenariosLoginFormPost()
        {
            Menu menu = new Menu();
            TestScenarios testscenarios = new TestScenarios();
            menu.TestScenarios.Click();
            testscenarios.LogInForm.Click();

        }
        public static void TestScenariosRegisterFormPost()
        {
            Menu menu = new Menu();
            TestScenarios testscenarios = new TestScenarios();
            menu.TestScenarios.Click();
            testscenarios.RegisterForm.Click();

        }
    }
}
