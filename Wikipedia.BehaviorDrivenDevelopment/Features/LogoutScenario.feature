Feature: LogoutScenario

Scenario: Successful logout with confirmation
	Given I am logged in bWAPP
	When I click on logout
	And I accept the alert
	Then I should be redirected to login page

Scenario: Cancel logout action
	Given I am logged in bWAPP
	When I click on logout
	And I dismiss the alert
	Then I should stay on portal page