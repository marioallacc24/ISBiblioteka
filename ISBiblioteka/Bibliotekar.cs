using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISBiblioteka
{
    public class Bibliotekar
    {
        private string username;
        private string password;

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }

        public Bibliotekar()
        {

        }

        public Bibliotekar(string username, string password)
        {
            Password = password;
            Username = username;
        }
    }
}
