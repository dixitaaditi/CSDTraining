using bo.JobPortal.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using bo.JobPortal;

namespace TestJobPortal
{
    [Binding]
    public class AddJobSteps
    {
        Job job = new Job();
        private List<string> result;

        [Given(@"""(.*)"" in JobTitle")]
        public void GivenInJobTitle(string p0)
        {
            ////ScenarioContext.Current.Pending();
            job.Title = p0;
        }
        
        [Given(@"""(.*)"" in SkillSet")]
        public void GivenInSkillSet(string p0)
        {
            ////ScenarioContext.Current.Pending();
            job.SkillSet  = p0;
        }
        
        [Given(@"""(.*)"" in Education")]
        public void GivenInEducation(string p0)
        {
            ////ScenarioContext.Current.Pending();
            job.Education = p0;
        }
        
        [When(@"Saved")]
        public void WhenSaved()
        {
            //ScenarioContext.Current.Pending();
            result = new JobSystem().Save(job);
        }

        [Then(@"I should get validation error for JobTitle")]
        public void ThenIShouldGetValidationErrorForJobTitle()
        {
            //ScenarioContext.Current.Pending();
            Assert.IsTrue(result.Any(r => r == "Job Title is a mandatory field"));
        }

        [Then(@"I should get validation error for SkillSet")]
        public void ThenIShouldGetValidationErrorForSkillSet()
        {
            //ScenarioContext.Current.Pending();
            Assert.IsTrue(result.Any(r => r == "Skill Set is a mandatory field"));
        }

        [Then(@"I should get validation error for Education")]
        public void ThenIShouldGetValidationErrorForEducation()
        {
            //ScenarioContext.Current.Pending();
            Assert.IsTrue(result.Any(r => r == "Education is a mandatory field"));
        }

        [Given(@"(.*)\tin Experience")]
        public void GivenInExperience(int p0)
        {
            //ScenarioContext.Current.Pending();
            job.Experience = p0;
        }

        [Given(@"""(.*)"" in Description")]
        public void GivenInDescription(string p0)
        {
            //ScenarioContext.Current.Pending();
            job.Description = p0;
        }

        [Then(@"the job should be saved successfully")]
        public void ThenTheJobShouldBeSavedSuccessfully()
        {
            //ScenarioContext.Current.Pending();
            Assert.IsTrue(result.Any(r => r == "Job Saved"));
        }

        [Given(@"""(.*)"" in Location")]
        public void GivenInLocation(string p0)
        {
            //ScenarioContext.Current.Pending();
            job.Location = p0;
        }

        [Given(@"""(.*)"" in Company")]
        public void GivenInCompany(string p0)
        {
            //ScenarioContext.Current.Pending();
            job.CompanyName = p0;
            
        }

        [Then(@"I should get validation error for Location")]
        public void ThenIShouldGetValidationErrorForLocation()
        {
            //ScenarioContext.Current.Pending();
            Assert.IsTrue(result.Any(r => r == "Invalid Location"));
        }


    }
}
