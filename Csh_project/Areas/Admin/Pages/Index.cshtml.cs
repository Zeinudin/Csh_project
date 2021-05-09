using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Csh_project.DAL.Data;
using Csh_project.DAL.Entities;

namespace Csh_project.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Csh_project.DAL.Data.ApplicationDbContext _context;

        public IndexModel(Csh_project.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
        }
    }
}
