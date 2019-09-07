using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input
{
    class loginInSystem
    {

        public static string loginIsValid()
        {
            Console.WriteLine("Введите логин");
            string userLogin = Console.ReadLine();
            return userLogin;
        }
        public static string passwordIsValid()
        {
            Console.WriteLine("Введите пароль");
            string userPassword = "";
            while (true)
            {
                char userChar = Console.ReadKey(true).KeyChar;
                userPassword += userChar;
                Console.Write("*");

                if (userChar == '\r')
                {
                    Console.WriteLine("\n Ваш пароль: " + userPassword);
                    break;
                }
            }
            return userPassword;
        }


    }

}
