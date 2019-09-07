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

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintDate()
        {
            Console.WriteLine($"имя: {Name} возраст: {Age}");
        }

    }
}
