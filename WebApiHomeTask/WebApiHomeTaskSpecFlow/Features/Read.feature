Feature: Read

#I read my booking data by ID from https://restful-booker.herokuapp.com WebAPI

@Read_ok
Scenario: Get my booking data by API
	Given My booking on the server
	When I send ID of my booking to the API
	Then I get OK status
	And I get my booking data

@Read_Error
Scenario: Try to get not valid booking ID
	Given I have a bad ID
	When I send the ID to API
	Then I get Not Found status code
