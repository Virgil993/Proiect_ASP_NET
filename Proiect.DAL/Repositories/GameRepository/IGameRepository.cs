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
    public interface IGameRepository : IGenericRepository<Game>
    {
        Task<Game> GetByName(string name);

        Task<List<Game>> GetAllGamesWithCategoryAndDeveloper();

        Task<Game> GetByIdWithCategoryAndDeveloper(int Id);

        
    }
}
