using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class DeveloperDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? GameId { get; set; }
        public Game Game { get; set; }

        public DeveloperDTO(Developer developer)
        {
            this.Id = developer.Id;
            this.FirstName = developer.FirstName;
            this.LastName = developer.LastName;
            this.Email = developer.Email;
            this.GameId = developer.GameId;
            this.Game = developer.Game;
        }
    }
}
