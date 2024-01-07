using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TruckManagement.Data;
using TruckManagement.Models;

namespace TruckManagement.Pages.Deliveries
{
    public class CreateModel : PageModel
    {
        private readonly TruckManagement.Data.TruckManagementDBContext _context;

        public CreateModel(TruckManagement.Data.TruckManagementDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["StatusID"] = new SelectList(_context.Set<Status>(), "ID",
            "StatusName");
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "ID",
            "UserName");
            return Page();
        }

        [BindProperty]
        public Delivery Delivery { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Delivery == null || Delivery == null)
            {
                return Page();
            }

            _context.Delivery.Add(Delivery);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
