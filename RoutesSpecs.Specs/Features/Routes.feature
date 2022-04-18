Feature: Routes
! This test

@mytag
Scenario Outline: Creating Possible Routes
	Given the text file 
	When creating possible routes
	When looking at a certain route <number>
	Then the first city should be <firstCity>
	Then the second city should be <secondCity>
	Then the distance should be <distance>
	Examples: 
	| number | firstCity | secondCity | distance |
	| 0      | London    | Dublin     | 464      |
	| 1      | London    | Belfast    | 518      |
	| 2      | Dublin    | Belfast    | 141      |

Scenario Outline: 
