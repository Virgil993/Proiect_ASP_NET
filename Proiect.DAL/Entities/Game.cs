using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Developer Developer { get; set; }

        public virtual ICollection<GameDevice> GameDevices { get; set; }

        
    }
}
