Feature: AuthenticationScenario

Authentication scenariis

@tag1
Scenario: As a visitor and on home page I want to click on "Se connecter" and be able to enter login / password then click button login
	Given I am a visitor at home page
	When I click on the link se connecter
	Then I am at authentication page
	When I fill input password and input login
	And I click on button se connecter
	Then I'm still at the same page
