using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;

namespace Bwapp.BehaviorDrivenDevelopment.StepDefinitions
{
    [Binding]
    public class LoginScenarioSuccessfullStepDefinitions
    {
        [Given("I am on login page")]
        public void GivenIAmOnLoginPage()
        {
            NavigationHelper.NavigateToUrl("http://localhost/login.php");
        }

        [When("I enter login {string}")]
        public void WhenIEnterLogin(string login)
        {
            TextBoxHelper.TypeInTextBox(By.Id("login"), login);
        }

        [When("I enter password {string}")]
        public void WhenIEnterPassword(string password)
        {
            TextBoxHelper.TypeInTextBox(By.Id("password"), password);
        }

        [When("I select security level low")]
        public void WhenISelectSecurityLevelLow()
        {
            ComboBoxHelper.SelectElement(By.Name("security_level"), 0);
        }

        [When("I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            ButtonHelper.ClickButton(By.CssSelector("button[type='submit']"));
        }

        [Then("I am connected to bWAPP")]
        public void ThenIAmConnectedToBwapp()
        {
            Assert.IsTrue(PageHelper.GetPageUrl().Contains("index.php")
                       || PageHelper.GetPageUrl().Contains("portal.php"));
        }
    }
}
