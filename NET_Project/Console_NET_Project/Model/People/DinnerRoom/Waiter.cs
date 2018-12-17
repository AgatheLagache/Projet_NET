using Console_NET_Project.Model.DinnerRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.People.DinnerRoom
{
    public class Waiter : Person
    {
        public Waiter(int id)
        {
            IsBusy = true;
            Id = id;
        }
        public void PutSomething(List<Command> listCommand, List<Table> listTable)
        {
            while (!SocketServer._leave)
            {
                foreach (var list in listCommand.ToList())
                {
                    if(list.IsReady == "Yes")
                    {
                        IsBusy = false;
                        Thread.Sleep(1500);
                        var groupCustomerQuery = (from groups in listGroupCustomerOnTable where groups.Id == list.NumeroGroup select groups).FirstOrDefault();
                        if(groupCustomerQuery != null)
                        {
                            list.IsReady = "Served";
                            IsBusy = true;
                            Console.WriteLine("Un serveur a servi le plat " + list.Dishes + " à la table n°" + groupCustomerQuery.NumeroTable);
                            GroupCustomer.ExitRestaurant(groupCustomerQuery.Id, listTable);
                        }
                    }
                }
            }
        }

        public void DropSomething()
        {
            /* action de récupérer quelque chose sur la table comme débarasser les couverts */
        }
    }
}
