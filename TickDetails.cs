namespace TicketManagement
{
    public class TickDetails
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Priority { get; set; } 
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string SnapshotPath { get; set; } // File path for snapshot
        public string Status { get; set; } // Open, In Progress, Closed
        public string CreatedBy { get; set; } // User ID
        public DateTime CreatedDate { get; set; }


    }
}
