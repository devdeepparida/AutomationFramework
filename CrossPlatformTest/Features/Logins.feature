Feature: Login
	Check if the login functionality is working
	as expected with different permutations and 
	combinations of data

@smoke @positive
Scenario: Check Login with correct username and password
	Given I have navigated to the application
	And I see application opened
	Then I click login link
	When I enter UserName and Password
	| UserName | Password |
	| admin    | password |
	Then I click login button
	Then I should see the username with hello
	Then I click logout

