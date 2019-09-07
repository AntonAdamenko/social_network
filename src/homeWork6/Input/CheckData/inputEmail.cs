using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input.CheckData
{
    class inputEmail
    {
        public static string inputEmailUser()
        {
            string email;
            bool emailIsValid = false;
            do
            {
                Console.WriteLine("Введите Email");
                email = Console.ReadLine();


                if (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("Это пустая строка. Enter-повторный ввод.Esc-выход");

                }
                else if (email.Contains('@') && email.Contains(".com"))
                {
                    emailIsValid = true;
                }
                else
                {
                    Console.WriteLine("email введен не корректно.Enter-повторный ввод. Esc-выход");
                }


                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }


            } while (!emailIsValid);
            return email;



        }

    }
}
