using _2022RestfullAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2022RestfullAPIApp.JobData
{
    public class SqlJobData : IJobData
    {
        private JobContext _jobContext;
        public SqlJobData(JobContext context)
        {
            _jobContext = context;
        }
        public Job AddJob(Job jobs)
        {
            jobs.Id = Guid.NewGuid();
            _jobContext.Jobs.Add(jobs);
            _jobContext.SaveChanges();

            return jobs;
        }

        public void DeleteJob(Job jobs)
        {
                _jobContext.Jobs.Remove(jobs);
            _jobContext.SaveChanges();
        }

        public Job EditJob(Job jobs)
        {
            var existingJob = _jobContext.Jobs.Find(jobs.Id);
            if (existingJob != null)
            {
                existingJob.Name = jobs.Name;
                _jobContext.Jobs.Update(existingJob);
                _jobContext.SaveChanges();
            }
            return jobs;
        }

        public Job GetJob(Guid id)
        {
            var findJob = _jobContext.Jobs.Find(id);
            return findJob;
            //return _jobContext.Jobs.SingleOrDefault(j => j.Id == id);
        }

        public List<Job> GetJobs()
        {
           return _jobContext.Jobs.ToList();
        }
    }
}
