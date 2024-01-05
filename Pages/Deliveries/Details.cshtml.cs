﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TruckManagement.Data;
using TruckManagement.Models;

namespace TruckManagement.Pages.Deliveries
{
    public class DetailsModel : PageModel
    {
        private readonly TruckManagement.Data.TruckManagementDBContext _context;

        public DetailsModel(TruckManagement.Data.TruckManagementDBContext context)
        {
            _context = context;
        }

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
    }
}
