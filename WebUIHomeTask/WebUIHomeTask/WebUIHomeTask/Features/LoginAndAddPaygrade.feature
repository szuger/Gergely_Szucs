Feature: LoginAndAddPaygrade

A short summary of the feature

@tag1
Scenario: I Login and add a new Paygrade
	Given I navigate to the website
	When I log in as Admin user
	Then I go to Admin page
	And I select Job/Pay Grade in n the horizontal menu
	And I add new pay grade
	And I set minimum salary, maximum salary
	