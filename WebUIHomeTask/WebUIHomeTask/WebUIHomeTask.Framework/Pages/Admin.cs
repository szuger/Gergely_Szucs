using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUIHomeTask.Framework.Pages
{
    public class Admin
    {
        private readonly IWebDriver _driver;
        public Admin(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement JobMenu => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/span"));
        public IWebElement PayGradeMenu => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul/li[2]/a"));
        public IWebElement AddButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button"));


        
    }
}
