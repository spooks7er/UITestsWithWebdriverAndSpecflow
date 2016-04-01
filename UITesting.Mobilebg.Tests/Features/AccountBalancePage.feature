Feature: Account Balance Page

Background: 
	Given I have navigated to the url 'http://www.mobile.bg/'
	And I have entered Username and Password
	| Username          | Password |
	| tester22016@abv.bg | 123456   |
	And Navigated to Account Balance

Scenario Outline: Move Slider and Assert Balance Bonus Percent
	When I Move the slider with <offset> percent
	Then The bonus should be <bonus> percent
Examples:
	| offset | bonus |
	| 1      | 1     |
	| 11     | 2     |
	| 51     | 6     |
	| 92     | 10    |
	| 100    | 10    |

Scenario Outline: See a confirmation code after selecting a payment option
	When I select a payment <option>
	And I agree to the terms
	And I click payment confirmation button
	Then I see a payment confirmation code
Examples: 
	| option           |
	| В брой /EasyPay/ |
	| С банков превод  |
	| На банкомат      |