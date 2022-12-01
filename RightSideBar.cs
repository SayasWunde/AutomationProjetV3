using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_project_v3
{
    public class RightSideBar
    {
        public RightSideBar() /*constructor for this class*/
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        /*search text field*/
        [FindsBy(How = How.CssSelector, Using = "#search-2 > form > label > input")]
        public IWebElement SearchField { get; set; }


        /*Recent posts section*/
        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(1) > a")]
        public IWebElement RecentPosts_DragAndDrop { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(2) > a")]
        public IWebElement RecentPosts_NewTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(3) > a")]
        public IWebElement RecentPosts_AlertBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(4) > a")]
        public IWebElement RecentPosts_Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(5) > a")]
        public IWebElement RecentPosts_Id { get; set; }


        /*Meta section*/
        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(1) > a")]
        public IWebElement Meta_Login { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(2) > a")]
        public IWebElement Meta_EntriesFeed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(3) > a")]
        public IWebElement Meta_CommentsFeed { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#meta-2 > ul > li:nth-child(3) > a")]
        public IWebElement Meta_WordPressOrg { get; set; }

    }
}
