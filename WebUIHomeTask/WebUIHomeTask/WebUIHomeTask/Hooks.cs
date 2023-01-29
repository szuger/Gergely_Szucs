using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace WebUIHomeTask
{
   [Binding]
   public class Hooks
   {
       private readonly IWebDriver _driver;
       private readonly ScenarioContext _scenarioContext;
       public Hooks(ScenarioContext context ) 
       {
            _driver = new ChromeDriver();
            _scenarioContext = context;     
       }
       
       [BeforeScenario]
       public void StartDriver() 
       {
           
       //    chromeDriver.AddArguments("start-maximized");
           _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           _scenarioContext["Driver"] = _driver;
       }
       /* [AfterScenario]
        public void StopDriver()
        {
            _driver.Close();
            _driver.Dispose();
           
        }*/
   }
}
