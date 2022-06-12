using _2022RestfullAPIApp.ApplicantData;
using _2022RestfullAPIApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _2022RestfullAPIApp.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private IApplicationData _applicationData;
        public ApplicantsController(IApplicationData applicationData)
        {
            _applicationData = applicationData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetApplications()
        {
            return Ok(_applicationData.GetApplications());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetApplicant(Guid id)
        {
            var applicant = _applicationData.GetApplicant(id);

            if (applicant != null)
            {
                return Ok(_applicationData.GetApplicant(id));
            }
            return NotFound("The Applicant with Application ID :{" + id + "} was not found");

        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetApplicant(Applicant applicant)
        {
            _applicationData.AddApplicant(applicant);


            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + applicant.id,
                       applicant);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteApplicant(Guid id)
        {
           var application = _applicationData.GetApplicant(id);

            if (application != null)
            {
                _applicationData.DeleteApplicant(application);
                return Ok();
            }
            return NotFound("The applicant with application ID :{" + id + "} was not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditApplicant(Guid id, Applicant applicant)
        {
            var existingapplication = _applicationData.GetApplicant(id);

            if (existingapplication != null)
            {
                applicant.id = existingapplication.id;
                _applicationData.EditApplicant(applicant);
                
            }
            return Ok(applicant);
           
        }
    }
}
