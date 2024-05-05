using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Xml.Linq;

namespace SupermarketWEB.Pages.Products
{
    public class IndexModel : PageModel
    {
            private readonly SupermarketContext _context;
            public IndexModel(SupermarketContext context)
            {
                _context = context;
            }
            public IList<Product> Products { get; set; }
            public async Task OnGetAsync()
            {

                Products = await _context.Products.ToListAsync();

            }
        }
    }


