using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input
{
    class generateID
    {       
            public static int GenerateId()
            {           

            string DBFilePath = @"C:\Users\Anton\source\repos\social_network\src\UsersData.json";           

            string s = "";

            using (FileStream fStream = File.OpenRead(DBFilePath))
            {
                byte[] bytesArray = new byte[fStream.Length];
                fStream.Read(bytesArray, 0, bytesArray.Length);
                s = Encoding.Default.GetString(bytesArray);
            }           

            if (s == "")
            {
                s = "[]";
            }

            User[] users = JsonConvert.DeserializeObject<User[]>(s);
            
            int ID = users.Length+1;

            foreach (User item in users)
            {
                if (ID.Equals(item.ID))
                {
                    ID = item.ID + 1;                    
                }                
            }  
            
            return ID;

        }

    }
}

