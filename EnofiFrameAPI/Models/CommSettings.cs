using GsmComm.GsmCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnofiFrameAPI.Models
{
    public class CommSettings
    {
        public static int Comm_Port = 0;
        public static Int64 Comm_BaudRate = 0;
        public static Int64 Comm_TimeOut = 0;
        public static GsmCommMain comm;
        public CommSettings()
        {

        }
    }
}
