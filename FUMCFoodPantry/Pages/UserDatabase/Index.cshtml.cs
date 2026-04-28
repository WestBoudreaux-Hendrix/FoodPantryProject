using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FUMCFoodPantry.Data;

namespace FUMCFoodPantry.Pages.UserDatabase
{
    public class IndexModel : PageModel
    {
        private readonly FUMCFoodPantry.Data.FUMCFoodPantryContext _context;

        public IndexModel(FUMCFoodPantry.Data.FUMCFoodPantryContext context)
        {
            _context = context;
        }

        public IList<UserApplications> UserApplications { get;set; } = default!;

        public async Task OnGetAsync()
        {
            UserApplications = await _context.UserApplications.ToListAsync();
        }
    }
}
