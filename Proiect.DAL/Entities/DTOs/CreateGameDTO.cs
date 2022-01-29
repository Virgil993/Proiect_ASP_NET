using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class CreateGameDTO
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Developer Developer { get; set; }
    }
}
