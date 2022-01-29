using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class GameDeviceDTO
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int DeviceId { get; set; }
        public Game Game { get; set; }
        public Device Device { get; set; }

        public GameDeviceDTO(GameDevice gameDevice)
        {
            this.Id = gameDevice.Id;
            this.GameId = gameDevice.GameId;
            this.DeviceId = gameDevice.DeviceId;
            this.Device = gameDevice.Device;
            this.Game = gameDevice.Game;
        }
    }
}
