using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class GameDevice
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public int DeviceId { get; set; }

        public virtual Game Game { get; set; }

        public virtual Device Device { get; set; }
    }
}
