using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicProvider.Data.Models
{
    public class Playlist
    {
        public Playlist()
        {
            this.PlaylistsSongs = new HashSet<PlaylistSong>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string PlaylistName { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<PlaylistSong> PlaylistsSongs { get; set; }
    }
}
