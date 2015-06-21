
using bo.JobPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace bo.JobPortal
{
    public class JobSystem
    {
        private readonly List<Job> jobs;
        private readonly List<String> Locations = new List<string>() { "Pune", "Chennai", "Bangalore", "Hyderabad", "Nagpur", "Mumbai" };
        public JobSystem()
        {
            jobs = new List<Job>();
        }

        public List<Job> SearchJobs(Job criteria, List<Error> errors)
        {
            return new List<Job> { new Job { Title = "SE" } };
        }

        public List<String> Save(Job job)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrWhiteSpace(job.Title))
                result.Add("Job Title is a mandatory field");
            if (string.IsNullOrWhiteSpace(job.SkillSet))
                result.Add("Skill Set is a mandatory field");
            if (string.IsNullOrWhiteSpace(job.Education))
                result.Add("Education is a mandatory field");
            if (!Locations.Any(l=> l.Equals(job.Location)))
            {
                result.Add("Invalid Location");
            }

            if (!result.Any())
            {
                jobs.Add(job);
                result.Add("Job Saved");
            }

            return result;
        }


    }
}
