using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace conseat
{
    public class Customer : User
    {
        public override string GetWelcomeMessage()
        {
            return "Welcome, dear customer!";
        }
    }

}
