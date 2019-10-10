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
            string DBFilePath = @"C:\Users\Antonio\source\repos\social_network\src\UsersData.json";
            List<User> users = Db.LoadUsersFromFileStatic(DBFilePath);

            
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

                        break;
                    }
            }
        }

        public static void deleteUser()
        {
            string DBFilePath = @"C:\Users\Antonio\source\repos\social_network\src\UsersData.json";
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
           
        }
    }
}
