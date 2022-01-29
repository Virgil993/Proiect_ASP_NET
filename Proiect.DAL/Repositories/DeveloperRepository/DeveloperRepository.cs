using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.DeveloperRepository
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(AppDbContext context) : base(context) { }
        public async Task<List<Developer>> GetAllDevelopersWithGame()
        {
            return await _context.Developers.Include(a => a.Game).ToListAsync();
        }

        public async Task<Developer> GetByIdWithGame(int Id)
        {
            return await _context.Developers.AsNoTracking().Include(a => a.Game).Where(a => a.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<Developer> GetByName(string firstname, string lastname)
        {
            return await _context.Developers.Where(a => a.FirstName.Equals(firstname)).Where(a => a.LastName.Equals(lastname)).FirstOrDefaultAsync();
        }
    }
}
