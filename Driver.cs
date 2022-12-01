using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_project_v3
{
    /*static so it wont have to be initials all the time , only one time is needed */
    public static class Driver
    {
        //public static IWebDriver driver = new ChromeDriver();
        public static IWebDriver driver { get; set; }
    }
}
