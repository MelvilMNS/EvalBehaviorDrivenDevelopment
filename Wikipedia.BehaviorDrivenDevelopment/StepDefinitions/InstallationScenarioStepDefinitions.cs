using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;

namespace Bwapp.BehaviorDrivenDevelopment.StepDefinitions
{
    [Binding]
    public class InstallationScenarioStepDefinitions
    {
        [Given("I am on install page")]
        public void GivenIAmOnInstallPage()
        {
            NavigationHelper.NavigateToUrl("http://localhost/install.php");
        }

        [When("I click on the link here")]
        public void WhenIClickOnTheLinkHere()
        {
            LinkHelper.ClickLink(By.LinkText("here"));
        }

        [Then("I am on installation confirmation page")]
        public void ThenIAmOnInstallationConfirmationPage()
        {
            Assert.AreEqual(
                "http://localhost/install.php?install=yes",
                PageHelper.GetPageUrl()
            );
        }
    }
}