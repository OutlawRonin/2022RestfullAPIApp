using _2022RestfullAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2022RestfullAPIApp.ApplicantData
{
    public class MockApplicationData : IApplicationData
    {
        public Job job = new Job();
        private List<Applicant> applicants = new List<Applicant>
        {

            new Applicant()
            {
                id = Guid.NewGuid(),
                Name = "JD van Niekerk",
                JobId = "8DFFCD8C-3BF4-4A35-AEE7-027CED4A43D2"
            },
            new Applicant()
            {
                id = Guid.NewGuid(),
                Name = "Joe Goose",
                JobId = "8DFFCD8C-3BF4-4A35-AEE7-027CED4A43D2"
            }

        };
        public Applicant AddApplicant(Applicant applicant)
        {
            applicant.id = Guid.NewGuid();
            //applicant.JobId = job.Id;//
            applicants.Add(applicant);
            return applicant;
        }

        public void DeleteApplicant(Applicant applicant)
        {
            applicants.Remove(applicant);
        }

        public Applicant EditApplicant(Applicant applicant)
        {
            var existingApplicant = GetApplicant(applicant.id);
            existingApplicant.Name = applicant.Name;
            existingApplicant.JobId = applicant.JobId;
           // existingApplicant.JobId = job.Id;//
            return existingApplicant;   
        }

        public Applicant GetApplicant(Guid id)
        {
            return applicants.SingleOrDefault(x => x.id == id);
        }

        public List<Applicant> GetApplications()
        {
            return applicants;
        }
    }
}
