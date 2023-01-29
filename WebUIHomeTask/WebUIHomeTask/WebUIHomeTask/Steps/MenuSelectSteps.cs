using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebUIHomeTask.Framework.Contexts;

namespace WebUIHomeTask.Steps
{
    [Binding]
    public class MenuSelectSteps
    {
        private readonly IWebDriver _driver;
        private readonly AdminContext _adminContext;

        public MenuSelectSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _adminContext = new AdminContext(_driver);
            
        }

        [Then(@"I select Job/Pay Grade in n the horizontal menu")]
        public void ThenISelectJobPayGradeInNTheHorizontalMenu()
        {
            _adminContext.SelectPayGradeMenu();
        }

    }
}
