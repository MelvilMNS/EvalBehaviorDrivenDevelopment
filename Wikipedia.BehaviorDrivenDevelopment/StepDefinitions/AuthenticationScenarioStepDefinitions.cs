using System;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using Reqnroll;

namespace Wikipedia.BehaviorDrivenDevelopment.StepDefinitions
{
    [Binding]
    public class AuthenticationScenarioStepDefinitions
    {
        [When("I click on the link se connecter")]
        public void WhenIClickOnTheLinkSeConnecter()
        {
            LinkHelper.ClickLink(By.LinkText("Se connecter"));
        }

        [Then("I am at authentication page")]
        public void ThenIAmAtAuthenticationPage()
        {
            Assert.AreEqual("Se connecter — Wikipédia", PageHelper.GetPageTitle());
        }

        [When("I fill input password and input login")]
        public void WhenIFillInputPasswordAndInputLogin()
        {
            TextBoxHelper.TypeInTextBox(By.Id("wpName1"), "Toto");
            TextBoxHelper.TypeInTextBox(By.Id("wpPassword1"), "Toto");
        }

        [When("I click on button se connecter")]
        public void WhenIClickOnButtonSeConnecter()
        {
            ButtonHelper.ClickButton(By.Id("wpLoginAttempt"));
        }

        [Then("I'm still at the same page")]
        public void ThenImStillAtTheSamePage()
        {
            Assert.AreEqual("Se connecter — Wikipédia", PageHelper.GetPageTitle());
        }
    }
}
