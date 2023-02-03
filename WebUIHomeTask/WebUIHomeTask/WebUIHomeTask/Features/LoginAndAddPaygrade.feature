Feature: LoginAndAddPaygrade

A short summary of the feature

@tag1
Scenario: I Login and add a new Paygrade
	Given I navigate to the website
	And I log in as Admin user
	And I go to Admin page
	When I select Job/Pay Grade in n the horizontal menu
	And I add new pay grade
	And I set <minS> minimum salary, <maxS> maximum salary
	Then I see my new pay grade is added
	Examples: 
	| minS   | maxS |
	| 1000   | 2000	|
	