using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input.CheckData
{
    class inputLogin
    {
        public static string inputLoginUser()
        {
            string login = "";
            do
            {
                Console.WriteLine("Введите login");
                login = Console.ReadLine();


                if (string.IsNullOrEmpty(login))
                {
                    Console.WriteLine("Это пустая строка. Введите еще раз");

                }
                else
                {
                    break;
                }



            } while (string.IsNullOrEmpty(login));
            return login;

        }

    }
}
