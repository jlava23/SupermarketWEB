using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _Context;

        public DeleteModel(SupermarketContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
            if (id == null || _Context.Categories == null)
            {
                return NotFound();
            }
            
            var category = await _Context.Categories.FindAsync(id);

            if (category != null)
            {
                Category = category;
                _Context.Categories.Remove(Category);
                await _Context.SaveChangesAsync();

            }

            return RedirectToPage(". /Index");
        }
           
    }
        
    
        
    }
    

    
   

