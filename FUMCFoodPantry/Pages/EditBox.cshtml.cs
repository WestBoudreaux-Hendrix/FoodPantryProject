using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FUMCFoodPantry.Pages;

public class EditBoxModel : PageModel
{
    
        private readonly FUMCFoodPantry.Data.FUMCFoodPantryContext _context;

        public EditBoxModel(FUMCFoodPantry.Data.FUMCFoodPantryContext context)
        {
            _context = context;
        }

        public IList<Stock> Stock { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Stock = await _context.Stock.ToListAsync();
        }
    
}
