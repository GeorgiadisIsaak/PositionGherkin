Feature: Customers Search
	#In order to avoid silly mistakes
	#As a math idiot
	#I want to be told the sum of two numbers

#Background: 
#	Given that we have some customers

@Important
Scenario: Search For Existent Customer
	Given I have entered 52035235 into the ΣΥΔΙΠΕΛ field
	When I press 'Next'
	Then a customer with the ΣΥΔΙΠΕΛ equal to 52035235 should be returned


	# Senario opou den epistrefetai tipota, ara kalo tha htan na kano ena Scenario Outline!


@Important
Scenario Outline: Search For Customer
	Given I have entered <Sydipel> into the ΣΥΔΙΠΕΛ field
	When I press 'Next'
	Then a customer with the ΣΥΔΙΠΕΛ equal to <Sydipel>, Επωνυμια equal to <Eponymia> and ΑΦΜ equal to <Afm> should be returned
	Examples: 
	| Sydipel  | Eponymia  | Afm        |
	| 52035235 | Marvel    | 23424515   |
	| 141414   | Microsoft | 13145252   |
	| 52035235 | Apple     | 2142143214 |
	
