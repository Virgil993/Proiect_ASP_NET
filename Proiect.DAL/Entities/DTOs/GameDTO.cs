using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public Developer Developer { get; set; }
        public List<GameDevice> GameDevices { get; set; }

        public GameDTO(Game game)
        {
            this.Id = game.Id;
            this.Name = game.Name;
            this.ReleaseDate = game.ReleaseDate;
            this.CategoryId = game.CategoryId;
            this.Category = game.Category;
            this.Developer = game.Developer;
            this.GameDevices = new List<GameDevice>();
        }
    }
}
