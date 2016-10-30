using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DomainModel.Entities
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

        public string Album { get; set; }

        public DateTime? Year { get; set; }

        public int? Rate { get; set; }

        public int? Duration { get; set; }

        public string Genre { get; set; }

    }
}
