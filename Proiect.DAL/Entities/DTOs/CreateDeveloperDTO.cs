using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class CreateDeveloperDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
