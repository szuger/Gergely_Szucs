Feature: Login

A short summary of the feature

@tag1
Scenario: I login
	Given I navigate to the website
	When I log in as Admin user
	Then I go to Admin page
	And I select Job/Pay Grade in n the horizontal menu
	And I add new pay grade with <name>
	#And I set <currency>, <minimum salary> and <maximum salary> 
	Examples: 
	| name       | currency | minimum salary | maximum salary |
	| RandomName | HUF      | 500000         | 600000         |