using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicProvider.Data.Models
{
    public class User
    {
        public User()
        {
            this.Playlists = new HashSet<Playlist>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
