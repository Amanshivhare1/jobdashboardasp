using System;

namespace JobDashboard.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
    }
}
