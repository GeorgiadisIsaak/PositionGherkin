Feature: Customers Search
	#In order to avoid silly mistakes
	#As a math idiot
	#I want to be told the sum of two numbers

#Background: 
#	Given that we have some customers

@Important
Scenario Outline: Search For Customer
	Given I have entered <Sydipel>
	When I press Next
	Then a customer with '<Eponymia>' and '<Afm>' should be returned

	Examples: 
		| Sydipel  | Eponymia  | Afm        |
		| 123145   | Marvel    | 23424515   |
		| 52035235 | Apple     | 2142143214 |
		| 141414   | Microsoft | 13145252   |