Feature: WalkingSkeleton
	In order to make sure the project is set up correctly
	As a user
	I want to add a new mapping file to a new project in the VS

Scenario: Add a new mapping file to a new CSharp class library project
	Given I have opened the VS
	And I have created a new CSharp class library project
	And I have added a new mapping file to the project
	When I open the mapping file
	Then mapping designer should open with a one default class created
