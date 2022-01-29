using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.DeviceRepository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Task<Device> GetByName(string name);
    }
}
