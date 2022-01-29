using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.CategoryRepository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context) { }
        public async Task<Category> GetByName(string name)
        {
            return await _context.Categories.Where(a => a.Name.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
