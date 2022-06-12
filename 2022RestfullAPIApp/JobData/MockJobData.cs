using _2022RestfullAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2022RestfullAPIApp.JobData
{
    public class MockJobData : IJobData
    {
        private List<Job> jobs = new List<Job>()
        {
            new Job()
            {
                Id = Guid.NewGuid(),
                Name = "First Job"
            },
            new Job()
            {
                Id = Guid.NewGuid(),
                Name = "Second Job"
            }
        };
        public Job AddJob(Job job)
        {
            job.Id = Guid.NewGuid();
            jobs.Add(job);
            return job;
        }

        public void DeleteJob(Job job)
        {
            jobs.Remove(job);
        }

        public Job EditJob(Job job)
        {
            var existingJob = GetJob(job.Id);
            existingJob.Name = job.Name;

            return existingJob;
        }

        public Job GetJob(Guid id)
        {
            return jobs.SingleOrDefault(x => x.Id == id);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }
    }
}
