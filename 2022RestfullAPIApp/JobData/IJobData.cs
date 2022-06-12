using _2022RestfullAPIApp.Models;
using System;
using System.Collections.Generic;

namespace _2022RestfullAPIApp.JobData
{
    public interface IJobData
    {
        List<Job> GetJobs();

        Job GetJob(Guid id);

        Job AddJob(Job jobs);

        void DeleteJob(Job jobs);

        Job EditJob(Job jobs);

    }
}
