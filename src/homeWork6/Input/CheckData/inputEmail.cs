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
                else if (checkAtEmail(email) == true)
                {
                    continue;
                }
                else if (email.Contains(".com") || email.Contains(".ru") || email.Contains(".travel"))
                {
                    emailIsValid = true;
                }
                else
                {
                    Console.WriteLine("Email введен не корректно. Укажите домен (например: .com, .ru, .travel).  Enter-повторный ввод. Esc-выход");
                }                                     
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }

            } while (!emailIsValid);
            return email;

           bool checkAtEmail(string str)
            {
                if (str.Contains('@'))
                {
                    int emalCharIndex = str.IndexOf("@");
                    string rightPart = str.Substring(emalCharIndex, str.Length - emalCharIndex);

                    if (rightPart.Length <= 2)
                    {
                        Console.WriteLine("После символа @ необходимо указать доменное имя");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Email должен содержать @");
                    return true;
                }
                return false;
            }

        }

    }
}
