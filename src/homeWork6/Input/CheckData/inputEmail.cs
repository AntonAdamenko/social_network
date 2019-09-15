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

                /*
                //todo: обработать ошибку отсутствия символа @ в строке.
                try
                {
                    if (!email.Contains('@'))
                    {

                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("нет такого элемента");
                }
                */


                int emalCharIndex = email.IndexOf("@");
                string rightPart = email.Substring(emalCharIndex, email.Length - emalCharIndex);


                if (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("Это пустая строка. Enter-повторный ввод.Esc-выход");
                }                
                else if (!email.Contains('@'))
                {
                    Console.WriteLine("Email введен не корректно.Enter-повторный ввод. Esc-выход");
                }              
                else if (rightPart.Length <= 2)
                {
                    Console.WriteLine("После символа @ необходимо указать доменное имя");                                       
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

           

        }

    }
}
