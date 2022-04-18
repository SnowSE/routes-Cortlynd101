Feature: Routes
! This test

@mytag
Scenario Outline: Creating Possible Routes
	Given the text file 
	When creating possible routes
	Then the first city should be <firstCity>
	Then the second city should be <secondCity>
	Then the distance should be <distance>
	Examples: 
	| firstCity | secondCity | distance |
	| London    | Dublin     | 464      |
	| London    | Belfast    | 518      |
	| Dublin    | Belfast    | 141      |

Scenario Outline: 
