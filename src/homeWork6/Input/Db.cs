using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input
{
    class Db
    {
        string filePath;

        public Db(string filePath)
        {
            this.filePath = filePath;
        }

        public static void SaveUsersToFile(string path, User [] users)
        {            
            // TODO: users --> jsonString
            string jsonString = GateJsonFromObject(users);
            using (FileStream fStream = File.Create(path))
            {
                byte[] bytesArray = Encoding.Default.GetBytes(jsonString);
                fStream.Write(bytesArray, 0, bytesArray.Length);
            }
            Console.WriteLine("файл успешно сохранен в" + path);
        }
        public List<User> LoadUsersFromFile()
        {
            //string path = @"C:\\Users\Антон\source\repos\Занятие8\lesson8\UsersData.json";
            string s = "";

            using (System.IO.FileStream fStream = File.OpenRead(this.filePath))
            {
                byte[] bytesArray = new byte[fStream.Length];
                fStream.Read(bytesArray, 0, bytesArray.Length);
                s = Encoding.Default.GetString(bytesArray);
            }
            Console.WriteLine("Файл успешно загружен");

            User[] users = Newtonsoft.Json.JsonConvert.DeserializeObject<User[]>(s);

            foreach (User item in users)
            {
                item.Print();
            }
            return new List<User>(users);
        }
        public static List<User> LoadUsersFromFileStatic(string path)
        {
            //string path = @"C:\\Users\Антон\source\repos\Занятие8\lesson8\UsersData.json";
            string s = "";

            using (System.IO.FileStream fStream = File.OpenRead(path))
            {
                byte[] bytesArray = new byte[fStream.Length];
                fStream.Read(bytesArray, 0, bytesArray.Length);
                s = Encoding.Default.GetString(bytesArray);
            }
            Console.WriteLine("Файл успешно загружен");

            if (s == "")
            {
                s = "[]";
            }

            User[] users = Newtonsoft.Json.JsonConvert.DeserializeObject<User[]>(s);

            foreach (User item in users)
            {
                item.Print();
            }
            return new List<User>(users);
        }
        private static string GateJsonFromObject(object obj)
        {
            string s = JsonConvert.SerializeObject(obj);
            return s;
        }
    }
}
