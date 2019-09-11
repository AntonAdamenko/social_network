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
                int lengthUserPassword = userPassword.Length;
                if (lengthUserPassword >= 6)
                {                    
                    passwordIsValid = true;
                }
                else
                {                    
                    Console.WriteLine("Пароль короткий. Придумайте длинней");
                }
                


            } while (!passwordIsValid);
            return userPassword;

        }
    }
}
