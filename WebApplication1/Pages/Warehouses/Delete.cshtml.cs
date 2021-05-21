using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Warehouses
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;

        public DeleteModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Warehouse Warehouse { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Warehouse = await _context.Warehouse.FirstOrDefaultAsync(m => m.ID == id);

            if (Warehouse == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Warehouse = await _context.Warehouse.FindAsync(id);

            if (Warehouse != null)
            {
                _context.Warehouse.Remove(Warehouse);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
