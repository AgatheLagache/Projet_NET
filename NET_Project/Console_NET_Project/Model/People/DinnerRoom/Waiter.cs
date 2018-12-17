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
        public Waiter()
        {
            IsBusy = true;
        }
        public void PutSomething(List<Command> listCommand, List<Table> listTable)
        {
            while (true)
            {
                foreach (var list in listCommand.ToList())
                {
                    if(list.IsReady == "Yes")
                    {
                        IsBusy = false;
                        Thread.Sleep(500);
                        var groupCustomerQuery = (from groups in listGroupCustomerOnTable where groups.Id == list.NumeroGroup select groups).FirstOrDefault();
                        list.IsReady = "Served";
                        IsBusy = true;
                        Console.WriteLine("Plat servi");
                        GroupCustomer.ExitRestaurant(groupCustomerQuery.Id, listTable);
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("Aucun plat dans l'état yes");
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
