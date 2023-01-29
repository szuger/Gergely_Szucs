using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebUIHomeTask.Framework.Contexts;

namespace WebUIHomeTask.Steps
{
    [Binding]
    public class PayGradesSteps
    {
        private readonly IWebDriver _driver;
        private readonly PayGradeContexts _payGradesContexts;

        public PayGradesSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _payGradesContexts = new PayGradeContexts(_driver);
            
        }

        [Then(@"I add new pay grade with RandomName")]
        public void ThenIAddNewPayGradeWithRandomName()
        {
            _payGradesContexts.addName(RandomName);


        }


    }
}

