using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input
{
    class hidePassword
    {
        public static string hideUserPassword()
        {
            Console.WriteLine("Введите пароль");
            string userPassword = "";
            while (true)
            {
                char userChar = Console.ReadKey(true).KeyChar;
                userPassword += userChar;
                Console.Write("*");
                //todo: При логине: после ввода пароля при нажатии Enter в конце строки записываеться символ \r и не дает войти в систему.
                if (userChar.Equals(Convert.ToChar(ConsoleKey.Enter)))
                {
                    Console.WriteLine("\n Ваш пароль: " + userPassword);
                    break;
                }
            }
            return userPassword;
        }
    }
}
