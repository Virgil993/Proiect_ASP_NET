using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.GameRepository
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(AppDbContext context) : base(context) { }

        public async Task<List<Game>> GetAllGamesWithCategoryAndDeveloper()
        {
            return await _context.Games.Include(a => a.Category).Include(a => a.Developer).ToListAsync();
        }

        public async Task<Game> GetByIdWithCategoryAndDeveloper(int Id)
        {
            return await _context.Games.AsNoTracking().Include(a => a.Category).Include(a => a.Developer).Where(a => a.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<Game> GetByName(string name)
        {
            return await _context.Games.Where(a => a.Name.Equals(name)).FirstOrDefaultAsync();
        }

       
    }
}
