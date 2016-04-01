Feature: Search Page

Background: 
	Given I have navigated to the url 'http://www.mobile.bg/'

Scenario: Custom search for cars
	When I do advanced search
	And I look for '4(5)' doors car
	And it has pictures
	And it is from private users only
	And it is from 2012 to 2014 year
	And it is from 10000 to 20000 leva
	And it is sorted by price
	Then I must see at least 1 result

Scenario Outline: Custom search for used tires
	When I do advanced search
	And Select Tire and Rims section
	And I select Tires
	And they are from 200 to 700 leva
	And they are with size <Width>/<Heigth>R<Diameter>
	And are of type Summer('Летни')
	Then I must see at least 1 result
Examples: 
	| Width | Heigth | Diameter |
	| 70    | 70     | 17       |
	| 245   | 30     | 20       |
	| 245   | 45     | 17       |	