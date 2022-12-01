using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3
{
    public class HomePage
    {

        public HomePage() /*constructor for this class*/
        {
            PageFactory.InitElements(Driver.driver , this);
        }

        [FindsBy(How =How.CssSelector ,Using ="#page-17 > header > h1")]
        public IWebElement HeadlineIntroduction { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(1) > a > img")]
        public IWebElement Image { get; set; }
    }
}
