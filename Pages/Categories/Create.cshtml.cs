using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly SumpermarketContext _Context;
        public CreateModel(SumpermarketContext context)
        {
            _Context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _Context.Categories == null || Category == null)
            {  
                return Page(); 
            }
            _Context.Categories.Add(Category);
            await _Context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
