using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;

namespace Bwapp.BehaviorDrivenDevelopment.StepDefinitions
{
    [Binding]
    public class LoginScenarioStepDefinitions
    {
        [Given("I am on login page")]
        public void GivenIAmOnLoginPage()
        {
            NavigationHelper.NavigateToUrl("http://localhost/login.php");
        }

        [When("I enter login")]
        public void WhenIEnterLogin()
        {
            TextBoxHelper.TypeInTextBox(By.Id("login"), "bee");
        }

        [When("I enter password")]
        public void WhenIEnterPassword()
        {
            TextBoxHelper.TypeInTextBox(By.Id("password"), "bug");
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
            // vérification simple et robuste
            Assert.IsTrue(PageHelper.GetPageUrl().Contains("index.php")
                       || PageHelper.GetPageUrl().Contains("portal.php"));
        }
    }
}
