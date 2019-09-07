using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input.CheckData
{
    class inputName
    {
        public static string inputNameUsers()
        {
            string name = "";
            do
            {
                Console.WriteLine("Введите имя");
                name = Console.ReadLine();


                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Это пустая строка. Введите еще раз");

                }
                else
                {
                    break;
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }


            } while (string.IsNullOrEmpty(name));
            return name;

        }


    }
}
