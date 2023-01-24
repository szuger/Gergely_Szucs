Feature: Delete

#Delet my booking from https://restful-booker.herokuapp.com WebAPI

@Delete_Ok
Scenario: Delete my booking
	Given I have my booking on the server
	When I send my booking ID to the server
	Then I get back the Created status code
	

@Delete_Error
Scenario: Try to delete my booking again
	Given I have my deleted booking ID
	When I send the ID to delete booking
	Then I get back a Method Not Allowed status