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


            Console.WriteLine("Введите логин");
            string getLogin = Console.ReadLine();           
           

            //User findUser = users.FirstOrDefault(item => item.Login == getLogin);             
            


            //todo: вместо foreach реализовать другой поиск пользователей в массиве.
            foreach (User item in users)
            {               
                if (item.Login == getLogin)
                {

                    //todo: Скрыть пароль *.  passwordIsValid();
                    Console.WriteLine("Введите пароль");
                    string pass = Console.ReadLine();
                    if (item.Password == pass)
                    {                       
                        Console.WriteLine("Повторите пароль");
                        string userPass = Console.ReadLine();
                        if (pass == userPass)
                        {
                            Console.WriteLine($"Добро пожаловать в систему {item.Name}");
                        }
                        else
                        {
                            Console.WriteLine("Пароль не совпал");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Пароль не верный. Можно восстановить пароль.");
                        Console.WriteLine("Введите Email");
                        string getEmail = Console.ReadLine();

                        if (item.Email == getEmail)
                        {
                            Console.WriteLine($"Инструкция смены пароля отправлена на почту:  {item.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Email введен не правильно");
                        }                                        
                    }
                }
                else
                {
                    Console.WriteLine("Такого пользователя нет. Зарегистрируйтесь");
                }
            }
            
            


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
