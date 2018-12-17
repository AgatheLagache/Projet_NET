using Console_NET_Project.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_NET_Project.Model.DinnerRoom
{
    public class HeadWaiter : Person
    {
        public HeadWaiter()
        {
            IsBusy = true;
        }
        public void ReceiveOrder()
        {
            /* reçoit les ordres du maitre d'hotel */
        }

        public void GiveMenu()
        {
            /* donne les menu aux clients */
        }

        public void TakeOrder(List<Command> listCommand)
        {
            // listGroupCustomerOnTable.Count != 0
            while (!SocketServer._leave)
            {
                foreach (GroupCustomer list in listGroupCustomerOnTable.ToList())
                {
                    Thread.Sleep(1500);
                    if (list.IsServed == false && list != null)
                    {
                        IsBusy = true;
                        listCommand.Add(new Command(GroupCustomer.ChooseDishes(), list.Id, 23));
                        list.IsServed = true;
                        Console.WriteLine("Le chef de rang a pris la commande du groupe n°" + list.Id);
                    }
                }
            }
        }

        public void GiveOrderToCommisChef()
        {
            /* donne les commandes aux commis de cuisine */
        }

        public void PutTable()
        {
            /* met la table après le passage de client */
        }
    }
}
