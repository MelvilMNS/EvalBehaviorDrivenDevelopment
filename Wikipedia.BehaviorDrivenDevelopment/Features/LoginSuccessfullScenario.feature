Feature: LoginScenarioSuccessfull

Scenario: As a user I want to login into bWAPP
	Given I am on login page
	When I enter login "bee"
	And I enter password "bug"
	And I select security level low
	And I click on login button
	Then I am connected to bWAPP