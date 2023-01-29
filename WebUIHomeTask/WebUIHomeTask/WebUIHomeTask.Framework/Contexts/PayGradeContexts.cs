using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUIHomeTask.Framework.Pages;

namespace WebUIHomeTask.Framework.Contexts
{
    public class PayGradeContexts
    {
        private readonly PayGrades _payGrades;
        //private readonly IWebDriver _driver;
        public PayGradeContexts(IWebDriver driver)
        {
            _payGrades = new PayGrades(driver);
            //  _driver = driver;
        }

        public void addName(string name)
        {
            _payGrades.addButton.Click();
            _payGrades.nameTextField.SendKeys(name);
            _payGrades.saveButton.Click();
        }
    }
}
