using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMusicStore.Models
{
    class Album
    {
        public int AlbumID { get; set; }

        public string Name { get; set; }

        public int ArtistID { get; set; }

        public string Year { get; set; }
    }
}
