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
            while (true)
            {
                foreach (GroupCustomer list in listGroupCustomerOnTable.ToList())
                {
                    if (list.IsServed == false && list != null)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("prise de commande");
                        IsBusy = true;
                        listCommand.Add(new Command(GroupCustomer.ChooseDishes(), list.Id));
                        list.IsServed = true;
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("ca marche");
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
