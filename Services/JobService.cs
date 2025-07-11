using JobDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class JobService
{
    // Replace with DB logic
    private List<Job> _jobs = new List<Job>
    {
        new Job { Id = 1, Title = "Job 1", Status = "Open", Date = DateTime.Today, Owner = "admin" },
        new Job { Id = 2, Title = "Job 2", Status = "Closed", Date = DateTime.Today.AddDays(-1), Owner = "viewer" }
    };

    public IEnumerable<Job> GetJobsByDate(string date)
    {
        DateTime parsedDate;
        if (!DateTime.TryParse(date, out parsedDate))
            parsedDate = DateTime.Today;
        return _jobs.Where(j => j.Date.Date == parsedDate.Date);
    }
}
