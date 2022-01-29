﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class CreateGameDeviceDTO
    {
        public int GameId { get; set; }
        public int DeviceId { get; set; }
        public Game Game { get; set; }
        public Device Device { get; set; }
    }
}
