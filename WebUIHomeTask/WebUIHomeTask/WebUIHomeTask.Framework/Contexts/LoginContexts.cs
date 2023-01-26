using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUIHomeTask.Framework.Pages;

namespace WebUIHomeTask.Framework.Contexts
{
    public class LoginContexts
    {
        private readonly LoginPage _loginPage;
        public LoginContexts(IWebDriver driver)
        {
            _loginPage= new LoginPage(driver);
        }
        public void Login(string username, string password)
        {
            _loginPage.UserNameTextField.SendKeys(username);
            _loginPage.PasswordTextField.SendKeys(password);
            _loginPage.LogInButton.Click();


        }
    }
}
