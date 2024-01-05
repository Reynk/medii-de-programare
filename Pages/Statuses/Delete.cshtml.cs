using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TruckManagement.Data;
using TruckManagement.Models;

namespace TruckManagement.Pages.Statuses
{
    public class DeleteModel : PageModel
    {
        private readonly TruckManagement.Data.TruckManagementDBContext _context;

        public DeleteModel(TruckManagement.Data.TruckManagementDBContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Status Status { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Status == null)
            {
                return NotFound();
            }

            var status = await _context.Status.FirstOrDefaultAsync(m => m.ID == id);

            if (status == null)
            {
                return NotFound();
            }
            else 
            {
                Status = status;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Status == null)
            {
                return NotFound();
            }
            var status = await _context.Status.FindAsync(id);

            if (status != null)
            {
                Status = status;
                _context.Status.Remove(Status);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
