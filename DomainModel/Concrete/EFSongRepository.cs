using DomainModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;

namespace DomainModel.Concrete
{
    public class EFSongRepository : ISongRepo
    {

        private SongDbContext context = new SongDbContext();
        public IEnumerable<Song> Songs
        {
            get
            {
                return context.Songs;
            }
        }

        public void Add(IEnumerable<Song> Songs)
        {
            foreach (var item in Songs)
            {
                context.Songs.Add(item);
            }

            
        }
    }
}
