using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver.Models
{
    public class User
    {
        public string Email { get; }

        public string Password { get;}

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
