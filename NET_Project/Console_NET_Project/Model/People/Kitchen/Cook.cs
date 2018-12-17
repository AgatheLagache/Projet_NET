using Console_NET_Project.Model.DinnerRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.People.Kitchen
{
    public class Cook : Person
    {
        public Cook()
        {
            IsBusy = false;
        }
        public void Cooking(List<Command> listCommand, List<Cook> listCook, List<GroupCustomer> listGroupCustomers)
        {
            //listGroupCustomers.Count != 0
            while (!SocketServer._leave)
            {
                foreach (var list in listCommand.ToList())
                {
                    Thread.Sleep(500);
                    if (list.IsReady == "In progress")
                    {
                        var chooseCookQuery = (from cook in listCook where cook.IsBusy == true select cook).FirstOrDefault();
                        if(chooseCookQuery != null)
                        {
                            Console.WriteLine("preparation plat");
                            Thread.Sleep(500);
                            list.IsReady = "Yes";
                            chooseCookQuery.IsBusy = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Rien a préparer");
                    }
                }
            }
        }

        public void Desposit()
        {
            /* poser les plats après les avoir terminés */
        }
    }
}
