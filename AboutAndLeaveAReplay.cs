
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3.UIElements
{

    class AboutAndLeaveAReplay
    {
        public AboutAndLeaveAReplay()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How =How.Id,Using= "comment")]
        public IWebElement Comment { get; set; }

        [FindsBy(How = How.Id, Using = "author")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "url")]
        public IWebElement WebSite { get; set; }

        [FindsBy(How = How.Id, Using = "wp-comment-cookies-consent")]
        public IWebElement SaveMyNameCheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement SubmitButton { get; set; }


    }
}
