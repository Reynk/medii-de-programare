using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TruckManagement.Data;
using TruckManagement.Models;

namespace TruckManagement.Pages.Deliveries
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : PageModel
    {
        private readonly TruckManagement.Data.TruckManagementDBContext _context;

        public DeleteModel(TruckManagement.Data.TruckManagementDBContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Delivery Delivery { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Delivery == null)
            {
                return NotFound();
            }

            var delivery = await _context.Delivery.FirstOrDefaultAsync(m => m.ID == id);

            if (delivery == null)
            {
                return NotFound();
            }
            else 
            {
                Delivery = delivery;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Delivery == null)
            {
                return NotFound();
            }
            var delivery = await _context.Delivery.FindAsync(id);

            if (delivery != null)
            {
                Delivery = delivery;
                _context.Delivery.Remove(Delivery);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
