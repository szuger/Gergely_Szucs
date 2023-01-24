Feature: Creat

# Creating new booking at https://restful-booker.herokuapp.com/ WebAPI

@Create_Ok
Scenario: I create a new booking.
	Given I have the data for a new booking  
	When I send the booking to the online service.
	Then I get back the OK status code
	And I get back new booking data

@Create_Error
Scenario: I  try to create a new booking with deficient data
	Given I have deficient data for a new booking  
	When I send the deficient booking data to the online service.
	Then I get back an Internal Server Error status code.
