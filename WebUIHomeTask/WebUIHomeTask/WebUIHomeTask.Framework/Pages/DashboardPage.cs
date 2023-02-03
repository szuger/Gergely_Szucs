using OpenQA.Selenium;


namespace WebUIHomeTask.Framework.Pages
{
    public class DashboardPage
    {
        private readonly IWebDriver _driver;
        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement AdminMenu => _driver.FindElement(By.XPath("//span[text()='Admin']"));
        
    } 
}
