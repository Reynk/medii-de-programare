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
    public class IndexModel : PageModel
    {
        private readonly TruckManagement.Data.TruckManagementDBContext _context;

        public IndexModel(TruckManagement.Data.TruckManagementDBContext context)
        {
            _context = context;
        }

        public IList<Delivery> Delivery { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Delivery != null)
            {
                Delivery = await _context.Delivery.ToListAsync();
            }
        }
    }
}
