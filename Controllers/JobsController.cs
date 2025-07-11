using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace JobDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class JobsController : ControllerBase
    {
        private readonly JobService _jobService;
        public JobsController(JobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public IActionResult GetJobs([FromQuery] string date)
        {
            try
            {
                var jobs = _jobService.GetJobsByDate(date);
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
