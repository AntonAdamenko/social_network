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
                                   
            string getLogin = inputLogin.inputLoginUser();       

            User findUser = users.FirstOrDefault(item => item.Login == getLogin);

            try
            {
                if (findUser.Login.Equals(getLogin))
                {
                    //todo: Скрыть пароль *.  hidePassword();

                    Console.WriteLine("Введите пароль");
                    string pass = Console.ReadLine();

                    if (findUser.Password.Equals(pass))
                    {
                        Console.WriteLine("Повторите пароль");
                        string userPass = Console.ReadLine();
                        if (pass.Equals(userPass))
                        {
                            Console.WriteLine($"Добро пожаловать в систему {findUser.Name}");
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

                        if (findUser.Email.Equals(getEmail))
                        {
                            Console.WriteLine($"Инструкция смены пароля отправлена на почту:  {findUser.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Email введен не правильно");
                        }
                    }
                }
            }

            catch (System.NullReferenceException)
            {                   
               Console.WriteLine("Такого пользователя нет. Зарегистрируйтесь");                
            }
        }        
    }
}
