using _2022RestfullAPIApp.Models;
using System;
using System.Collections.Generic;

namespace _2022RestfullAPIApp.ApplicantData
{
    public interface IApplicationData
    {
        List<Applicant> GetApplications();

        Applicant GetApplicant(Guid id);

        Applicant AddApplicant(Applicant applicant);

        void DeleteApplicant(Applicant applicant);

        Applicant EditApplicant (Applicant applicant);
    }
}
