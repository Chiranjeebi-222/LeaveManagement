using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LeaveManagement;
using LeaveManagement.Models;
using System.Collections.Generic;
using System.Linq;

public class ApplyModel : PageModel
{
    private readonly LeaveDbContext _context;

    public ApplyModel(LeaveDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public LeaveRequest LeaveRequest { get; set; }

    public List<SelectListItem>
    LeaveTypes
    { get; set; }

    public void OnGet()
    {
        LeaveTypes = _context.LeaveTypes
        .Select(t => new SelectListItem { Value = t.TypeID.ToString(), Text = t.TypeName })
        .ToList();
    }

    public IActionResult OnPost()
    {
        LeaveRequest.Status = "Pending";
        _context.LeaveRequests.Add(LeaveRequest);
        _context.SaveChanges();
        return RedirectToPage("History");
    }
}
