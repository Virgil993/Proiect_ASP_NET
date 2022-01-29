using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.DeviceRepository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(AppDbContext context) : base(context) { }

        public async Task<Device> GetByName(string name)
        {
            return await _context.Devices.Where(a => a.Name.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
