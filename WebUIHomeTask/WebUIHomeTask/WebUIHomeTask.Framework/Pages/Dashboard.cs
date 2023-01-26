using OpenQA.Selenium;


namespace WebUIHomeTask.Framework.Pages
{
    public class Dashboard
    {
        private readonly IWebDriver _driver;
        public Dashboard(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement AdminMenu => _driver.FindElement(By.XPath("//span[text()='Admin']"));
        
    } 
}
