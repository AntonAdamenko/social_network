using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6.Input
{
    class generateID
    {       
            public static string GenerateId()
            {

                byte[] buffer = Guid.NewGuid().ToByteArray();
                var FormNumber = BitConverter.ToUInt32(buffer, 0) ^ BitConverter.ToUInt32(buffer, 4) ^ BitConverter.ToUInt32(buffer, 8) ^ BitConverter.ToUInt32(buffer, 12);
                string ID = FormNumber.ToString("X");

                return ID;

            }
        
    }
}

