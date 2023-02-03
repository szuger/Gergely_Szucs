using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUIHomeTask.Framework.Pages
{
    public class AdminPage
    {
        private readonly IWebDriver _driver;
        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement JobMenu => _driver.FindElement(By.XPath("//nav[@class='oxd-topbar-body-nav']/ul/li[2]"));
        public IWebElement PayGradeMenu => _driver.FindElement(By.XPath("//ul[@class='oxd-dropdown-menu']/li[2]"));
        public IWebElement AddButton => _driver.FindElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--secondary']"));


        
    }
}
