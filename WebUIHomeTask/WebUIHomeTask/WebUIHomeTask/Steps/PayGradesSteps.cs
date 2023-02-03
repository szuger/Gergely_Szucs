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
        private const string PayGradeName = "RandomName";
        private const string MinimumSalary = "100";
        private const string MaximumSalary = "200";

        public PayGradesSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _payGradesContexts = new PayGradeContexts(_driver);
            
        }

        [When(@"I add new pay grade")]
        public void WhenIAddNewPayGrade()
        {
            _payGradesContexts.AddName(PayGradeName);
        }
        [When(@"I set (.*) minimum salary, (.*) maximum salary")]
        public void WhenISetMinimumSalaryMaximumSalary(string minS, string maxS)
        {
            _payGradesContexts.AddCurrency(maxS, minS);
        }



    }
}

