using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;

namespace Bwapp.BehaviorDrivenDevelopment.StepDefinitions
{
    [Binding]
    public class LogoutScenarioStepDefinitions
    {
        [Given("I am logged in bWAPP")]
        public void GivenIAmLoggedInBWAPP()
        {
            NavigationHelper.NavigateToUrl("http://localhost/login.php");
            TextBoxHelper.TypeInTextBox(By.Id("login"), "bee");
            TextBoxHelper.TypeInTextBox(By.Id("password"), "bug");
            ComboBoxHelper.SelectElement(By.Name("security_level"), 0);
            ButtonHelper.ClickButton(By.CssSelector("button[type='submit']"));
        }

        [When("I click on logout")]
        public void WhenIClickOnLogout()
        {
            LinkHelper.ClickLink(By.LinkText("Logout"));
        }

        [When("I accept the alert")]
        public void WhenIAcceptTheAlert()
        {
            AlertHelper.Accept();
        }

        [Then("I should be redirected to login page")]
        public void ThenIShouldBeRedirectedToLoginPage()
        {
            Assert.AreEqual("http://localhost/login.php", PageHelper.GetPageUrl());
        }

        [When("I dismiss the alert")]
        public void WhenIDismissTheAlert()
        {
            AlertHelper.Dismiss();
        }

        [Then("I should stay on portal page")]
        public void ThenIShouldStayOnPortalPage()
        {
            Assert.IsTrue(PageHelper.GetPageUrl().Contains("portal.php"));
        }

    }
}
