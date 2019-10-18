using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input
{
    class User
    {
        public string Name { private set; get; }
        public int Age { private set; get; }
        public string Email { private set; get; }
        public string Login { private set; get; }
        public string Password { set; get; }
        public int ID { private set; get; }

        public User(string name, int age, string login, string email, string password, int id)
        {
            Name = name;
            Age = age;            
            Login = login;
            Email = email;
            Password = password;
            ID = id;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {Name} Возраст: {Age}  Login {Login} Email {Email} Password {Password} ID {ID}");
        }

    }
}
