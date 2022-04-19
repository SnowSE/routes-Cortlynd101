Feature: Routes
! This feature will take in a file with routes listed and make them into a list. It will then use that list to determine what the best possible route is while touching place in the list.

@mytag
Scenario Outline: Creating Possible Routes
	Given the text file C:\Users\Cortl\source\repos\routes-Cortlynd101\Routes\TestInput.txt
	When creating possible routes
	When looking at a certain route number <number>
	Then the first city should be <firstCity>
	Then the second city should be <secondCity>
	Then the distance should be <distance>
	Examples: 
	| number | firstCity | secondCity | distance |
	| 0      | London    | Dublin     | 464      |
	| 1      | London    | Belfast    | 518      |
	| 2      | Dublin    | Belfast    | 141      |

Scenario: Check Best Route Small Sample
	Given the text file C:\Users\Cortl\source\repos\routes-Cortlynd101\Routes\TestInput.txt
	When creating possible routes
	When finding the best route
	Then the best first city should be London
	Then the best second city should be Dublin
	Then the best third city should be Belfast
	Then the best distance should be 605

Scenario: Check Best Route Large Sample
	Given the text file C:\Users\Cortl\Source\Repos\routes-Cortlynd101\Routes\Input.txt
	When creating possible routes
	When finding the best route
	Then the best first city should be toBeDetermined
	Then the best second city should be toBeDetermined
	Then the best third city should be toBeDetermined
	Then the distance should be toBeDetermined