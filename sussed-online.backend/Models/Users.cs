using System.Collections.Generic;

namespace sussed_online.backend.Models
{
    public class Users
    {
        public IEnumerable<User> SussedUsers { get; set; } = new List<User>();
    }
}