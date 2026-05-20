using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using Reqnroll;
using System;

namespace Wikipedia.BehaviorDrivenDevelopment.StepDefinitions
{
    [Binding]
    public class ResearchScenarioStepDefinitions
    {
        [Given("I am a visitor at home page")]
        public void GivenIAmAVisitorAtHomePage()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [When("I fill research input")]
        public void WhenIFillResearchInput()
        {
            TextBoxHelper.TypeInTextBox(By.Id("searchInput"), "Intelligence artificielle");
        }

        [When("I click on research button")]
        public void WhenIClickOnResearchButton()
        {
            ButtonHelper.ClickButton(By.XPath("//*[@id=\"searchform\"]/button"));
        }

        [Then("I am on the page I searched")]
        public void ThenIAmOnThePageISearched()
        {
            // Soit j'utilise l'url
            var expectedPage = Path.Combine(
                ObjectRepository.Config.GetWebsite(),
                "wiki/Intelligence_artificielle"
            );
            Assert.AreEqual(expectedPage, PageHelper.GetPageUrl());
        }

        [Then("I am on the specific research page")]
        public void ThenIAmOnTheSpecificResearchPage()
        {
            // Soit j'utilise le titre de la page
            Assert.AreEqual("Rechercher — Wikipédia", PageHelper.GetPageTitle());
        }
    }
}
