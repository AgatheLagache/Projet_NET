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
        public Cook(int id)
        {
            IsBusy = false;
            Id = Id;
        }
        public void Cooking(List<Command> listCommand, List<Cook> listCook, List<GroupCustomer> listGroupCustomers)
        {
            while (!SocketServer._leave)
            {
                foreach (var list in listCommand.ToList())
                {
                    if (list.IsReady == "In progress")
                    {
                        Thread.Sleep(2000);
                        var chooseCookQuery = (from cook in listCook where cook.IsBusy == true select cook).FirstOrDefault();
                        if(chooseCookQuery != null)
                        {
                            Console.WriteLine("Le cuisinier n°" + chooseCookQuery.Id + " prépare le plat : " + list.Dishes);
                            list.IsReady = "Yes";
                            chooseCookQuery.IsBusy = false;
                        }
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
