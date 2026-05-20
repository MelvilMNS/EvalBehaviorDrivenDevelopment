Feature: LoginScenario

Scenario: Successful login into bWAPP
	Given I am on login page
	When I enter login "bee"
	And I enter password "bug"
	And I select security level low
	And I click on login button
	Then I am connected to bWAPP

Scenario: Failed login with invalid credentials
	Given I am on login page
	When I enter login "wronguser"
	And I enter password "wrongpass"
	And I select security level low
	And I click on login button
	Then I should see a login error message
	And I should stay on login page