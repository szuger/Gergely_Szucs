Feature: Update

#Update my booking firstname at https://restful-booker.herokuapp.com/ WebAPI

@Update_Ok
Scenario: Update first name in my booking
	Given I have the id of the updated booking
	When I send booking with updated firstname
	Then I get back the Ok statuse code
	And I get back the booking with the updated first name

@Update_Error
Scenario: I try to update non existing booking
	Given I have a non exisitng booking ID
	When I try to update the booking
	Then I get back a Method Not Allowed status code.
