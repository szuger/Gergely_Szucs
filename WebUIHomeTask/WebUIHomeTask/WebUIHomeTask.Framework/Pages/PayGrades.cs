using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUIHomeTask.Framework.Pages
{
    public class PayGrades
    {
        private readonly IWebDriver _driver;
        public PayGrades(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement addButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div[1]/div/button"));
        public IWebElement nameTextField => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div/div/div[2]/input"));
        public IWebElement saveButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]"));
        public IWebElement addCurenciesButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div/div[1]/div/button"));
        public IWebElement selectCurenciesButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[1]/div/div/div/div[2]/div/div/div[2]/i"));
        public IWebElement minSalary => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[2]/div/div[1]/div/div[2]/input"));
        public IWebElement maxSalary => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[2]/div/div[2]/div/div[2]/input"));
        public IWebElement saveSalary => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[3]/button[2]"));








    }
}
