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
            loginInSistem = 2,
            humanInSistem = 3
        }
        static void Main(string[] args)
        {

            Console.WriteLine($"Добро пожаловать! \n Для регистрации нажмите 1 \n Чтобы войти в систему нажмите 2\n Если вы вошли нажмите 3");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("Регистация");

                    inputName.inputNameUsers();
                    inputAge.inputAgeUsers();
                    inputLogin.inputLoginUsers();
                    inputEmail.inputEmailUsers();



                    registration user = new registration(age, name, login, email);

                    List<registration> users = new List<registration>();
                    users.Add(user);

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
