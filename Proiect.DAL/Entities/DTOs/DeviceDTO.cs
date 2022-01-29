using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class DeviceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GameDevice> GameDevices { get; set; }

        public DeviceDTO(Device device)
        {
            this.Id = device.Id;
            this.Name = device.Name;
            this.GameDevices = new List<GameDevice>();
        }
    }
}
