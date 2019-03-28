using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
 
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public Gender gender { get; set; }
    }
}
