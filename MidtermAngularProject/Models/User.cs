using System;
using System.Collections.Generic;

#nullable disable

namespace MidtermAngularProject.Models
{
    public partial class User
    {
        public User()
        {
            Favorites = new HashSet<Favorite>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}
