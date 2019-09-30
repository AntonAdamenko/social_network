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

        public static void SaveUsersToFile(string path, User[] users)
        {

            string jsonString = GateJsonFromObject(users);
            using (FileStream fStream = File.Create(path))
            {
                byte[] bytesArray = Encoding.Default.GetBytes(jsonString);
                fStream.Write(bytesArray, 0, bytesArray.Length);
            }
            Console.WriteLine("Файл успешно сохранен в " + path);

           

        }
        public List<User> LoadUsersFromFile()
        {

            string s = "";

            using (FileStream fStream = File.OpenRead(this.filePath))
            {
                byte[] bytesArray = new byte[fStream.Length];
                fStream.Read(bytesArray, 0, bytesArray.Length);
                s = Encoding.Default.GetString(bytesArray);
            }
            Console.WriteLine("Файл успешно загружен");

            User[] users = JsonConvert.DeserializeObject<User[]>(s);

            foreach (User item in users)
            {
                item.Print();
            }
            return new List<User>(users);
        }
        public static List<User> LoadUsersFromFileStatic(string path)
        {

            string s = "";

            using (FileStream fStream = File.OpenRead(path))
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

            User[] users = JsonConvert.DeserializeObject<User[]>(s);

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
