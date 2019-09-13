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

            bool passwordIsValid = false;
            do
            {
                userPassword = Console.ReadLine();

                if (string.IsNullOrEmpty(userPassword))
                {
                    Console.WriteLine("Это пустая строка. Введите еще раз");
                }
                else if (userPassword.Length < 6)
                {
                    Console.WriteLine("Пароль должен содержать минимум 6 символов");
                }
                else if (IsNumberContains(userPassword) == false)
                {
                    Console.WriteLine("Пароль должен содержать минимум одну цифру");
                }
                else if (IsCapitalLetter(userPassword) == false)
                {
                    Console.WriteLine("Пароль должен содержать минимум одну большую букву");
                }
                else
                {
                    passwordIsValid = true;
                }                                            
            } while (!passwordIsValid);
            return userPassword;


            

            bool IsNumberContains(string str)
            {
                {
                    foreach (char c in str)
                        if (Char.IsNumber(c))
                            return true;                    
                }
                return false;
            }
            bool IsCapitalLetter(string str)
            {
                {
                    foreach (char c in str)
                    {
                        if (Char.IsUpper(c))
                            return true;
                    }
                    return false;                    
                }               
            }



        }
    }
}
