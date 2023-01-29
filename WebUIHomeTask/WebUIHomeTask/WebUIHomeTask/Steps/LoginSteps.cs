using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebUIHomeTask.Framework.Contexts;

namespace WebUIHomeTask.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginContexts _loginContext;
        private readonly DashboardContext _dashBoardContext;
        private const string UserName = "Admin";
        private const string Password = "admin123";
        
         public LoginSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _loginContext = new LoginContexts(_driver);
            _dashBoardContext = new DashboardContext(_driver);
        } 

        [When(@"I log in as Admin user")]
        public void WhenILogInAsAdminUser()
        {
            _loginContext.Login(UserName, Password);
        }


        [Then(@"I go to Admin page")]
        public void ThenIAmLoggedIn()
        {
            //var actual = _dashBoardContext.isPageLoaded();
            _dashBoardContext.goToAdminMenu();
           // Assert.That(actual, Is.True);
        }


    }
}
