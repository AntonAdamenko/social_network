using System;
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
            loginIn = 2,
            userInSystemNow = 3,
            test=4
        }
        static void Main(string[] args)
        {

            Console.WriteLine($"Добро пожаловать! \n Для регистрации нажмите 1 \n Чтобы войти в систему нажмите 2\n Если вы вошли нажмите 3");
            int userNumber = int.Parse(Console.ReadLine());
            string DBFilePath = @"C:\Users\Anton\source\repos\social_network\src\UsersData.json";
            //var db = new Db(DBFilePath);

            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("Регистация");

                    List<User> users = Db.LoadUsersFromFileStatic(DBFilePath);

                    var name = inputName.inputNameUser();
                    var age = inputAge.inputAgeUser();
                    var login = inputLogin.inputLoginUser();                   
                    var email = inputEmail.inputEmailUser();
                    var salt = hashClass.salt(10);
                    var password = hashClass.hashPasswordRegistration(salt);
                    var ID = generateID.GenerateId();

                    User user = new User(name, age, login, email, salt, password, ID);                    
                    users.Add(user);
                    Db.SaveUsersToFile(DBFilePath, users.ToArray());

                    break;

                case 2:
                    Console.WriteLine("Логин");
                    
                    loginIn.userInSystem();                   

                    break;
                case 3:
                    Console.WriteLine("Пользователь в системе");

                    userInSystemNow.userInSystem();

                    break;
                case 4:
                    Console.WriteLine("test");
                    var randomString = hashClass.salt(10);
                    Console.WriteLine(randomString);
                    break;

                default:
                    Console.WriteLine("Для выхода нажмите Esc.");
                    break;
            }

        }
    }
}
