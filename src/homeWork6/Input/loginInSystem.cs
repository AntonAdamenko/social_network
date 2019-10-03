using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homeWork6.Input.CheckData;

namespace homeWork6.Input
{
    class loginInSystem
    {        

        public static void loginIsValid()
        {
            string DBFilePath = @"C:\Users\Antonio\source\repos\social_network\src\UsersData.json";
            List<User> users = Db.LoadUsersFromFileStatic(DBFilePath);

            

            string log = inputLogin.inputLoginUser();

            //Console.WriteLine("Повторите ввод");
            //string userLogin = Console.ReadLine();

            foreach (User item in users)
            {
                if (item.Login == log)
                {
                    Console.WriteLine("Введите пароль");
                    string pass = Console.ReadLine();
                    if (item.Password == pass)
                    {
                        Console.WriteLine($"Добро пожаловать в систему {item.Name}");
                    }
                    else
                    {
                        Console.WriteLine("Пароль не совпал. Можно восстановить пароль.");
                        string userEmail = inputEmail.inputEmailUser();
                        //todo: проверить есть ли такой email в базе и отправить на него инструкцию по смене пароля.
                    }
                }
                else
                {
                    Console.WriteLine("Такого пользователя нет. Зарегистрируйтесь");
                }
            }




            //return userLogin;
        }
        public static string passwordIsValid()
        {
            Console.WriteLine("Введите пароль");
            string userPassword = "";
            while (true)
            {
                char userChar = Console.ReadKey(true).KeyChar;
                userPassword += userChar;
                Console.Write("*");
                //todo: При логине: после ввода пароля при нажатии Enter в конце строки записываеться символ \r и не дает войти в систему.
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
