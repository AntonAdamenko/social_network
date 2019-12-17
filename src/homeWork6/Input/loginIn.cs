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
    class loginIn
    {    
        public static void userInSystem()
        {
            string DBFilePath = @"C:\Users\Anton\source\repos\social_network\src\UsersData.json";
            List<User> users = Db.LoadUsersFromFileStatic(DBFilePath);

            string getLogin = inputLogin.inputLoginUser();
            

            User findUser = users.FirstOrDefault(item => item.Login == getLogin);
            
            try
            {
                //todo: Скрыть пароль *.  hidePassword();
                    var getSalt = findUser.Salt;
                    Console.WriteLine("Введите пароль");
                    string pass = Console.ReadLine();
                    var getHashPass1 = hashClass.EncryptPassword(pass, getSalt);
                    if (findUser.Password.Equals(getHashPass1))
                    {
                        Console.WriteLine("Повторите пароль");
                        string userPass = Console.ReadLine();
                        var getHashPass2 = hashClass.EncryptPassword(userPass, getSalt);
                       if (getHashPass1.Equals(getHashPass2))
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
            catch (NullReferenceException)
            {                   
               Console.WriteLine("Такого пользователя нет. Зарегистрируйтесь");                
            }
        }        
    }
}
