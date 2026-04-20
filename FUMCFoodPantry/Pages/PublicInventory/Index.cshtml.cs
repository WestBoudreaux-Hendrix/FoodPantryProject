using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FUMCFoodPantry.Data;

namespace FUMCFoodPantry.Pages.PublicInventory
{
    public class IndexModel : PageModel
    {
        private readonly FUMCFoodPantryContext _context;

        public IndexModel(FUMCFoodPantryContext context)
        {
            _context = context;
        }

        public IList<Stock> Stock { get; set; } = new List<Stock>();

        public async Task OnGetAsync()
        {
            Stock = await _context.Stock
                .OrderBy(s => s.Item)
                .ToListAsync();
        }
    }
}