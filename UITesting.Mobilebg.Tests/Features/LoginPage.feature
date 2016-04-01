Feature: Login Page

Background: 
	Given I have navigated to the url 'http://www.mobile.bg/'

Scenario: Login with valid Credentials
	Given I have entered Username and Password
	| Username           | Password | Firstname | Lastname |
	| tester22016@abv.bg | 123456   | tester    | tester   |
	Then I should see my Firstname and Lastname in the profile box


Scenario: Login with invalid Credentials
	Given I have entered Username and Password
	| Username    | Password |
	| invalidUser | 123456   |
	Then I should see an error message