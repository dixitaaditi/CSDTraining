Feature: Add job
	As a recruiter 
	I want to add a job 
	So that job seekers can view it

@development
#Scenario: Enter job details 
#Given I visit home page of job portal
#When I press add job
#Then job entry screen should open

@development
Scenario: Validate JobTitle
	Given "" in JobTitle
	And "BE" in Education
	When Saved
	Then I should get validation error for JobTitle
 Scenario: Validate SkillSet
	Given "" in SkillSet
	When Saved
	Then I should get validation error for SkillSet
 Scenario: Validate Education
	Given "" in Education
	When Saved
	Then I should get validation error for Education
 @development
Scenario: Post fresher job 
	Given "Software Engineer" in JobTitle
	And  0	in Experience
	And  "Java, SQL server, JavaScript" in SkillSet
	And  "" in Description
	And  "BE" in Education
	And "Pune" in Location
	And "Sungard Financial Systems" in Company
	When Saved
	Then the job should be saved successfully

Scenario: Validate Location
Given "ppp" in Location
When Saved
Then I should get validation error for Location


