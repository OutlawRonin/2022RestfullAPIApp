using _2022RestfullAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2022RestfullAPIApp.ApplicantData
{
    public class SqlApplicationData : IApplicationData
    {
        private JobContext _context;
        //private Job job = new Job();    
        public SqlApplicationData(JobContext applicationContext)
        {
            _context = applicationContext;
        }
        public Applicant AddApplicant(Applicant applicant)
        {
            applicant.id = Guid.NewGuid();
            _context.applicants.Add(applicant);
            //applicant.JobId = job.Id;
            _context.SaveChanges();
            return applicant;
        }

        public void DeleteApplicant(Applicant applicant)
        {
            
            _context.applicants.Remove(applicant);
            _context.SaveChanges();
        }

        public Applicant EditApplicant(Applicant applicant)
        {
            var existingApplicant = _context.applicants.Find(applicant.id);
            if (existingApplicant != null)
            {
                existingApplicant.Name = applicant.Name;
                existingApplicant.JobId = applicant.JobId;
                _context.applicants.Update(existingApplicant);
                _context.SaveChanges();
            }
            return applicant;
        }

        public Applicant GetApplicant(Guid id)
        {
            var findApplicant = _context.applicants.Find(id);
            return findApplicant;
        }

        public List<Applicant> GetApplications()
        {
           return _context.applicants.ToList();
        }
    }
}
