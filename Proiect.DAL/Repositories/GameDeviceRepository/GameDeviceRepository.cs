using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.GameDeviceRepository
{
    public class GameDeviceRepository : GenericRepository<GameDevice>, IGameDeviceRepository
    {
        public GameDeviceRepository(AppDbContext context) : base(context) { }
        public async Task<List<GameDevice>> GetAllGameDevicesWithGameAndDevice()
        {
            return await _context.GameDevices.Include(a => a.Game).Include(a=>a.Device).ToListAsync();
        }

        public async Task<GameDevice> GetByIdWithGameAndDevice(int Id)
        {
            return await _context.GameDevices.AsNoTracking().Include(a => a.Game).Include(a=>a.Device).Where(a => a.Id == Id).FirstOrDefaultAsync();
        }
    }
}
