using LeaveManagement.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class LeaveHistoryModel : PageModel
{
    private readonly LeaveDbContext _context;

    public LeaveHistoryModel(LeaveDbContext context) => _context = context;

    public List<LeaveRequest> Requests { get; set; }

    public void OnGet()
    {
        int studentId = 1; // Replace with logged-in user's ID
        Requests = _context.LeaveRequests
            .Where(r => r.StudentID == studentId)
            .Include(r => r.LeaveType)
            .ToList();
    }
}
