using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebUIHomeTask.Framework.Pages;

namespace WebUIHomeTask.Framework.Contexts
{
    public class DashboardContext
    {
        private readonly Dashboard _dashBoard;
        private readonly IWebDriver _driver;

        public DashboardContext(IWebDriver driver)
        {
            _dashBoard = new Dashboard(driver);
            _driver = driver;
        }
     /*   public bool isPageLoaded()
        {
            var adminMenu = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(10)
            }.Until(d => _dashBoard.AdminMenu);  
            return adminMenu != null && adminMenu.Displayed;
        }*/
        public void goToAdminMenu()
        {
            _dashBoard.AdminMenu.Click();
        }
    }
}
