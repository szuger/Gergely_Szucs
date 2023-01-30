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

        public void AddName(string name)
        {
            _payGrades.AddButton.Click();
            _payGrades.NameTextField.SendKeys(name);
            _payGrades.SaveButton.Click();
        }
        public  void AddCurrency(string minS, string maxS)
        {
          
            _payGrades.AddCurenciesButton.Click();
            //Thread.Sleep(1000);
            _payGrades.SelectCurrency.SendKeys("hhhhhh\n");
            _payGrades.AED.Click();
            _payGrades.MaxSalary.SendKeys(minS);
            _payGrades.MinSalary.SendKeys(maxS);
            _payGrades.SaveSalary.Click();

        }
        
    }
}
