using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input.CheckData
{
    class inputAge
    {

        public static int inputAgeUsers()
        {
            string userString1;
            bool IsInteger = false;
            int age = 0;
            do
            {
                Console.WriteLine("Введите возраст");
                userString1 = Console.ReadLine();


                if (string.IsNullOrEmpty(userString1))
                {
                    Console.WriteLine("Это пустая строка. Введите еще раз");
                }
                else if (int.TryParse(userString1, out int userNumber))
                {

                    age = userNumber;
                    if (age <= 0)
                    {
                        Console.WriteLine("Возраст введен не корректно");
                    }
                    else
                    {
                        IsInteger = true;

                    }


                }

            } while (!IsInteger);
            return age;
        }
    }
}
