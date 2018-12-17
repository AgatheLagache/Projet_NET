using DLL_Library_NET_Project.Service;
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
        public int Price { get; set; }
        public Command(string command, int numberGroup, int price)
        {
            Dishes = command;
            NumeroGroup = numberGroup;
            IsReady = "No";
            Price = price;
        }

        public static int GetPrice(string dish)
        {
            /* retourne le prix d'un plat */
            return 0;
        }
    }
}
