using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicProvider.Data.Models
{
    public class Song
    {
        public Song()
        {
            this.PlaylistsSongs = new HashSet<PlaylistSong>();
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string SongName { get; set; }

        [Required]
        [MaxLength(150)]
        public string SongArtist { get; set; }
        public ICollection<PlaylistSong> PlaylistsSongs { get; set; }

    }
}
