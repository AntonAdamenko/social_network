using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input.CheckData
{
    class inputPassword
    {
        public static string inputPasswordUser()
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
