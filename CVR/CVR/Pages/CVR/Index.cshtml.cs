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
    public class IndexModel : PageModel
    {
        private readonly CVR.Data.CVRContext _context;

        public IndexModel(CVR.Data.CVRContext context)
        {
            _context = context;
        }

        public IList<CvrEntry> CvrEntry { get;set; }

        public async Task OnGetAsync()
        {
            CvrEntry = await _context.CvrEntry.ToListAsync();
        }
    }
}
