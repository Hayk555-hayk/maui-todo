using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace ToDoApp.Data
{
    public class User
    {
        private Guid _sessionId;
        protected string _userName;
        private string _password;

        public string WelcomeUser { get { return $"Hello dear {Name}"; } }

        public string Name { get { return _userName; } set { _userName = value; } }

        public User(string name, string password)
        {
            _sessionId = Guid.NewGuid();
            
            _password = password;
            Name = name;
        }

        public bool CheckPass()
        {
            if (Name != "Hayk" && _password != "password")
            {
                return false;
            }

            return true;
        }
    }
}
