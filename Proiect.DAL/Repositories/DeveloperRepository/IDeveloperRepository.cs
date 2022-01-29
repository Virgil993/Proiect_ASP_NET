using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.DeveloperRepository
{
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        Task<Developer> GetByName(string firstname, string lastname);

        Task<List<Developer>> GetAllDevelopersWithGame();

        Task<Developer> GetByIdWithGame(int Id);
    }
}
