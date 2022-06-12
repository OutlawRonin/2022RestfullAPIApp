using _2022RestfullAPIApp.JobData;
using _2022RestfullAPIApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _2022RestfullAPIApp.Controllers
{
    
    [ApiController]
    public class JobController : ControllerBase
    {
        private IJobData _jobData;
        public JobController(IJobData jobs)
        {
            _jobData = jobs;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetJobs()
        {

            return Ok(_jobData.GetJobs());

        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetJob(Guid id)
        {
            var job = _jobData.GetJob(id);

            if (job != null)
            {
                return Ok(job);
            }

            return NotFound("The Job with Job ID :{" + id +"} was not found");

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetJob(Job job)
        {
            _jobData.AddJob(job);

           return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + job.Id,
                       job );
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteJob(Guid id)
        {
            var job = _jobData.GetJob(id);

            if (job != null)
            {
                _jobData.DeleteJob(job);
                return Ok();
            }
            return NotFound("The Job with Job ID :{" + id + "} was not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditJob(Guid id, Job job)
        {
            var existingJob = _jobData.GetJob(id);

            if (existingJob != null)
            {
                job.Id = existingJob.Id;
                _jobData.EditJob(job);
               
            }

            return Ok(job);
        }

    }
}
