Feature: ResearchScenario

On wikipedia I want the research feature to be working

@tag1
Scenario: I am at home page and I try to do a research, it send me to the page I searched
	Given I am a visitor at home page
	When I fill research input
	And I click on research button
	Then I am on the page I searched

Scenario: I am at home page I try to click on research without filling input, it send me to a research page
	Given I am a visitor at home page
	When I click on research button
	Then I am on the specific research page
