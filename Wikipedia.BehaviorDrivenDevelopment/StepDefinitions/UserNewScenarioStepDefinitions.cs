using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;

namespace Bwapp.BehaviorDrivenDevelopment.StepDefinitions
{
    [Binding]
    public class UserNewScenarioStepDefinitions
    {
        [Given("I am on new user page")]
        public void GivenIAmOnNewUserPage()
        {
            NavigationHelper.NavigateToUrl("http://localhost/user_new.php");
        }

        [When("I enter user login {string}")]
        public void WhenIEnterUserLogin(string login)
        {
            TextBoxHelper.TypeInTextBox(By.Id("login"), login);
        }

        [When("I enter user email {string}")]
        public void WhenIEnterUserEmail(string email)
        {
            TextBoxHelper.TypeInTextBox(By.Id("email"), email);
        }

        [When("I enter user password {string}")]
        public void WhenIEnterUserPassword(string password)
        {
            TextBoxHelper.TypeInTextBox(By.Id("password"), password);
        }

        [When("I retype user password {string}")]
        public void WhenIRetypeUserPassword(string password)
        {
            TextBoxHelper.TypeInTextBox(By.Id("password_conf"), password);
        }

        [When("I enter user secret {string}")]
        public void WhenIEnterUserSecret(string secret)
        {
            TextBoxHelper.TypeInTextBox(By.Id("secret"), secret);
        }

        [When("I do not check email activation")]
        public void WhenIDoNotCheckEmailActivation()
        {
            // RAS
        }

        [When("I click on create button")]
        public void WhenIClickOnCreateButton()
        {
            ButtonHelper.ClickButton(By.CssSelector("button[type='submit']"));
        }

        [Then("I should see user created success message")]
        public void ThenIShouldSeeUserCreatedSuccessMessage()
        {
            Assert.IsTrue(
                ObjectRepository.Driver.PageSource.Contains("User successfully created")
            );
        }

        [Then("I should see user already exists error")]
        public void ThenIShouldSeeUserAlreadyExistsError()
        {
            Assert.IsTrue(
                ObjectRepository.Driver.PageSource.Contains("already exists")
            );
        }
    }
}
