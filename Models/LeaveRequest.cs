namespace LeaveManagement.Models
{
    public class LeaveRequest
    {
        public int RequestID { get; set; }

        public int StudentID { get; set; }
        public User? Student { get; set; }

        public int LeaveTypeID { get; set; }
        public LeaveType? LeaveType { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string? Reason { get; set; }
        public string? Status { get; set; }
    }
}
