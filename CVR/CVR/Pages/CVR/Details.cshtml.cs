using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CVR.Data;
using CVR.Models;

namespace CVR
{
    public class DetailsModel : PageModel
    {
        private readonly CVR.Data.CVRContext _context;

        public DetailsModel(CVR.Data.CVRContext context)
        {
            _context = context;
        }

        public CvrEntry CvrEntry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CvrEntry = await _context.CvrEntry.FirstOrDefaultAsync(m => m.ID == id);

            if (CvrEntry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
