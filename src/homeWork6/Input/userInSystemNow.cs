using homeWork6.Input.CheckData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input
{
    class userInSystemNow
    {
        enum Menu
        {
            deleteUser=1,
            changePassword = 2
        }


        public static void userInSystem()
        {                               
            Console.WriteLine("Вы в системе. \n Нажмите 1 для удаления профиля. \n Нажмите 2 для того чтобы сменить пароль.");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    {
                        Console.WriteLine("Удаление профиля");
                        deleteUser();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Смена пароля");
                        changePassword();
                        break;
                    }
            }
        }

        public static void deleteUser()
        {
            string DBFilePath = @"C:\Users\Anton\source\repos\social_network\src\UsersData.json";
            List<User> users = Db.LoadUsersFromFileStatic(DBFilePath);

            string getLogin = inputLogin.inputLoginUser();

            User findUser = users.FirstOrDefault(item => item.Login == getLogin);
            try
            {
                users.Remove(findUser);
                Console.WriteLine($"Пользователь {findUser.Name} удален.");
                Db.SaveUsersToFile(DBFilePath, users.ToArray());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Такого пользователя нет");
            }            
        }
        public static void changePassword()
        {
            string DBFilePath = @"C:\Users\Anton\source\repos\social_network\src\UsersData.json";
            List<User> users = Db.LoadUsersFromFileStatic(DBFilePath);

            string getLogin = inputLogin.inputLoginUser();

            

            try
            {
                User findUser = users.FirstOrDefault(item => item.Login == getLogin);

                Console.WriteLine("Введите старый пароль");
                string pass = Console.ReadLine();

                if (findUser.Password.Equals(pass))
                {
                    Console.WriteLine("Повторите старый пароль");
                    string userPass = Console.ReadLine();
                    if (pass.Equals(userPass))
                    {                        
                        string newPassword = inputPassword.inputPasswordUser();
                        findUser.Password = findUser.Password.Replace(userPass, newPassword);                        
                        Console.WriteLine($"Пользователь {findUser.Name} заменил пароль.");
                        Db.SaveUsersToFile(DBFilePath, users.ToArray());
                    }
                    else
                    {
                        Console.WriteLine("Пароль не совпал");
                    }
                }
                else
                {
                    Console.WriteLine("Пароль не верный.");
                }
            }
            catch (NullReferenceException)
            {            
               Console.WriteLine("Такого пользователя нет.");                
            }
        }
    }
}
