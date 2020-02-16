using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CVR.Data;
using CVR.Models;

namespace CVR
{
    public class EditModel : PageModel
    {
        private readonly CVR.Data.CVRContext _context;

        public EditModel(CVR.Data.CVRContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CvrEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CvrEntryExists(CvrEntry.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CvrEntryExists(int id)
        {
            return _context.CvrEntry.Any(e => e.ID == id);
        }
    }
}
