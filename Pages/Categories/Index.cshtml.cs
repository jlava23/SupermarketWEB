using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Categories
{
    public class Indexmodel : PageModel
    {

        private readonly SupermarketContext _context;

        public Indexmodel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<Category> Categories { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Categories = await _context.Categories.ToListAsync();
            }
        }
    }
}


