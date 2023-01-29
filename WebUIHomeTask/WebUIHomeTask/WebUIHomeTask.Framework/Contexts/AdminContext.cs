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
    public class AdminContext
    {
        private readonly Admin _admin;
        //private readonly IWebDriver _driver;
        public AdminContext(IWebDriver driver)
        {
            _admin = new Admin(driver);
          //  _driver = driver;
        }
        
        public void SelectPayGradeMenu()
        {
            _admin.jobMenu.Click();
            _admin.payGradeMenu.Click();
           // _admin.addButton.Click();
        }
    }
}
