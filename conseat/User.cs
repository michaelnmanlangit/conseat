using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conseat
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public virtual string GetWelcomeMessage()
        {
            return "Welcome!";
        }
    }
}
