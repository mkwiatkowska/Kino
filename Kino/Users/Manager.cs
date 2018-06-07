using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Users
{
    public class Manager : Person
    {
        public Manager(int id, string login = "", string password = "", string email = "", string name = "", string surname = "", State state = State.Manager) : base(id, login, password, email, name, surname, state)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.email = email;
            this.name = name;
            this.surname = surname;
        }
    }
}
