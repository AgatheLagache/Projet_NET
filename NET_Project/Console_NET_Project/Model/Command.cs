using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project.Model
{
    public class Command
    {
        public string Dishes { get; set; }
        public int NumeroGroup { get; set; }
        public string IsReady { get; set; }
        public Command(string command, int numberGroup)
        {
            Dishes = command;
            NumeroGroup = numberGroup;
            IsReady = "No";
        }
    }
}
