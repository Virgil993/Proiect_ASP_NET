using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.GameDeviceRepository
{
    public interface IGameDeviceRepository : IGenericRepository<GameDevice>
    {
        Task<List<GameDevice>> GetAllGameDevicesWithGameAndDevice();

        Task<GameDevice> GetByIdWithGameAndDevice(int Id);
    }
}
