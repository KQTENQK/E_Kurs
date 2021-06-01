using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kurs
{
    public class Moderator
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string UserType { get; private set; }

        public Moderator(int id, string username, string password, string userType)
        {
            Id = id;
            Username = username;
            Password = password;
            UserType = userType;
        }
    }
}
