using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        public string Group { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
