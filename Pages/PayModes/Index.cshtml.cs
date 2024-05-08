using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.PayModes
{
    public class IndexModel : PageModel
    {
        
            private readonly SupermarketContext _context;
            public IndexModel(SupermarketContext context)
            {
                _context = context;
            }
            public IList<PayMode> PayModes { get; set; }
            public async Task OnGetAsync()
            {
                //if (_context.Categories != null)
                //{
                PayModes = await _context.PayModes.ToListAsync();
                //}
            }

        
    }
}
