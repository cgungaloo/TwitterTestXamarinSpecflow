Feature: Login

@ignore
Scenario:Incorrect Login
	Given I am on the login screen
	When I login with an incorrect username and password
	Then an error message will come up

@loginScreen @logout
Scenario: Login
	Given I am on the login screen
	When I login with correctusername and password
	Then I will be on the twitter homescreen
