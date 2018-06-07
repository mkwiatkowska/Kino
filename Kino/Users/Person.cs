using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Users
{
    public abstract class Person
    {
        public int id;
        public string login;
        protected string password;
        protected string email;
        public string name;
        public string surname;
        public State state;

        public Person(int id, string login = "", string password = "", string email = "", string name = "", string surname = "", State state = State.Guest)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.email = email;
            this.name = name;
            this.surname = surname;
            this.state = state;
        }

        public void BuyTicket()
        {

        }
        public void ReturnTicket()
        { }
        public override string ToString()
        {
            return "ID = {id}\nLogin = {login}\nPassword = {password}\nEmail = {email}\nName = {name}\nSurname = {surname}\nState = {state}";
        }
        public void SeeRepertoire()
        { }
        public void SeeDiscounts()
        { }

        /*
        public abstract void AddToRepertoire();
        public abstract void ModifyRepertoire();
        public abstract void RemoveMovieFromRepertoire();
        public abstract void RemoveUser(string ID);
        public abstract void AddUser();
        public abstract void SellTicket();
        
        public abstract void CreateDiscount();*/
    }
}
