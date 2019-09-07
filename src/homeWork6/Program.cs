﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homeWork6.Input;
using homeWork6.Input.CheckData;

namespace homeWork6
{
    class Program
    {

        enum menu
        {
            registration = 1,
            loginInSistem = 2,
            humanInSistem = 3
        }
        static void Main(string[] args)
        {

            Console.WriteLine($"Добро пожаловать! \n Для регистрации нажмите 1 \n Чтобы войти в систему нажмите 2\n Если вы вошли нажмите 3");
            int userNumber = int.Parse(Console.ReadLine());
            string DBFilePath = @"C:\Users\Antonio\source\repos\social_network\src\UsersData.json";
            //var db = new Db(DBFilePath);

            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("Регистация");
                    List<User> users = Db.LoadUsersFromFileStatic(DBFilePath);

                    var name = inputName.inputNameUsers();
                    var age = inputAge.inputAgeUsers();
                    var login = inputLogin.inputLoginUsers();
                    // TODO: изменить валидацию email
                    var email = inputEmail.inputEmailUsers();

                    User user = new User(name, age, login, email);                    
                    users.Add(user);
                    Db.SaveUsersToFile(DBFilePath, users.ToArray());


                    break;
                case 2:
                    Console.WriteLine("Логин");

                    loginInSystem.loginIsValid();
                    loginInSystem.passwordIsValid();

                    break;
                case 3:
                    Console.WriteLine("Пользователь в системе");
                    break;
                default:
                    Console.WriteLine("Для выхода нажмите Esc. Для повторного вызова меню нажмите 7");
                    break;
            }

        }
    }
}
