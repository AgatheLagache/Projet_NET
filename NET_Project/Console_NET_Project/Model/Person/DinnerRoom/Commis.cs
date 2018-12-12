using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.DinnerRoom
{
    public class Commis
    {
        private static Commis uniqueInstance;

        protected Commis()
        {

        }

        public static Commis Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Commis();
            }
            return uniqueInstance;
        }

        public void CheckClientOk()
        {

        }
    }
}
