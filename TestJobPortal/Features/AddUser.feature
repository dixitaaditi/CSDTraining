Feature: AddUser
	As a user of job portal 
	I should be able to create my profile

@mytag
Scenario: Add Recruiter 
	Given "Recruiter" in UserType
	And "Recruiter1" in Name
	And "aditi.dixit@sungard.com" in Email
	And "9881474441" in Phone
	And null in Resume
	When I press add
	Then the result should be 120 on the screen
