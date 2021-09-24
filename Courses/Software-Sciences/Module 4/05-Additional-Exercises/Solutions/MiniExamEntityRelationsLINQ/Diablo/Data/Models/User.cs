using System;
using System.Collections.Generic;

#nullable disable

namespace Diablo.Data.Models
{
    public partial class User
    {
        public User()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }
        public string IpAddress { get; set; }

        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
