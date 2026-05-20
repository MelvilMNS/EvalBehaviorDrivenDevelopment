Feature: UserNewScenario

Scenario: Successfully create a new user
	Given I am on new user page
	When I enter user login "oh"
	And I enter user email "oh@oh.com"
	And I enter user password "oh"
	And I retype user password "oh"
	And I enter user secret "oh"
	And I do not check email activation
	And I click on create button
	Then I should see user created success message

Scenario: Fail to create an existing user
	Given I am on new user page
	When I enter user login "oh"
	And I enter user email "oh@oh.com"
	And I enter user password "oh"
	And I retype user password "oh"
	And I enter user secret "oh"
	And I do not check email activation
	And I click on create button
	Then I should see user already exists error