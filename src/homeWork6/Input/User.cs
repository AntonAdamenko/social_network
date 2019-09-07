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

        public string Password { private set; get; }

        public User(string name, int age, string email, string login, string password)
        {
            Name = name;
            Age = age;
            Email = email;
            Login = login;
            Password = password;
        }
        public void Print()
        {
            Console.WriteLine($"имя: {Name} возраст: {Age} Email {Email} Login {Login} Password {Password}");
        }

    }
}
